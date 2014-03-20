using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1 {
  class SimplexSolver {

    private int[] N;       // Indicies of non-basic variables
    private int[] B;       // Indicies of basic variables
    private double[,] A;      // Our padded matrix
    private double[] b;    // Padding at the end
    private double[] c;    // Coefficients of objective function
    private double v = 0;  // Our result

    public SimplexSolver() {
      this.setupValues();
    }

    public Tuple<double[], double> Solve() {
      // e is the index of intering variable
      int e = -1;
      do {
        // There exists an e in N that's positive
        if ((e = firstPosInN()) != -1) {
          double delta_min = int.MaxValue; // Min of all the deltas
          int l = -1;                      // Index of leaving variable
          foreach (int i in B) {           // For each index of the basic variables
            if (a_sub(i, e) > 0) {         // Get a position in matrix A
              // delta is the ratio for the current constraint
              double delta = b_sub(i) / a_sub(i, e);
              if (delta < delta_min) {
                // Dela min is smaller
                delta_min = delta;
                // Change the leaving variable index
                l = i;
              }
            }
          }
          // l is now the index of the smallest delta
          if (delta_min == int.MaxValue) { // If delta_min is infinity
            // We have an unbounded problem
            return Tuple.Create(new double[0], double.MinValue);
          } else {
            Pivot(l, e);
          }
        } else {
          e = -1;
        }
      } while (e != -1);

      // Last: Clean up 'c
      for (int i = 0; i < b.Length; i++) {
        if (Contains(B, i)) {
          c[i] = b[i];
        } else {
          c[i] = 0;
        }
      }

        return Tuple.Create(c, v);
    }

    private void Pivot(int l, int e) { 
      double[] b_hat = new double[b.Length];          // Temp the size of b
      double[,] a_hat = new double[A.Length,9];       // Temp A matrix
      double[] c_hat = new double[c.Length];          // Temp C

      // Step 1: Compute coefficients for constraints for new basic variable x_sub_e
      b_hat[e] = b_sub(l) / a_sub(l, e);

      foreach (int j in SubsetSubtract(N, e)) {
        a_hat[e, j] = a_sub(l, j) / a_sub(l, e);
      }

      a_hat[e, l] = 1 / a_sub(l, e);

      // Step 2: Compute new coefficients for other constraints
      foreach (int i in SubsetSubtract(B, l)) { 
        b_hat[i] = b_sub(i) - ( a_sub(i, e) * b_hat[e] );

        foreach (int j in SubsetSubtract(N, e)) {
          a_hat[i, j] = a_sub(i, j) - ( a_sub(i, e) * a_hat[e, j] ); 
        }

        a_hat[i, l] = (-a_sub(i, e)) * a_hat[e, l];
      }

      // Step 3: Compute new objective function
      double v_hat = v + ( c[e] * b_hat[e] );

      foreach (int j in SubsetSubtract(N, e)) {
        c_hat[j] = c[j] - (c[e] * a_hat[e, j]);
      }

      c_hat[l] = (-c[e]) * a_hat[e, l];

      // Swap Indicies
      N = SubsetCombine( SubsetSubtract(N, e), l);
      B = SubsetCombine( SubsetSubtract(B, l), e);
      // Assign the values from pivot result
      c = c_hat;
      A = a_hat;
      b = b_hat;
      v = v_hat;
    }

    private void setupValues() {
      // The padded matrix
      this.A = new double[9, 9] {
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0.1, 0.5, 0.33, 1, 0, 0, 0, 0, 0},
        {30, 15, 19, 12, 0, 0, 0, 0, 0},
        {1000, 6000, 4100, 9100, 0, 0, 0, 0, 0},
        {50, 20, 21, 10, 0, 0, 0, 0, 0},
        {4, 6, 19, 30, 0, 0, 0, 0, 0}
      };

      // Values Padded
      this.c = new double[9] { 10.2, 422.30, 6.91, 853, 0, 0, 0, 0, 0 };

      // Constraints padded
      this.b = new double[9] { 0, 0, 0, 0, 2000, 1000, 1000000, 640, 432 };

      // Basic and Non-basic Variables
      this.N = new int[4] { 0, 1, 2, 3 };
      this.B = new int[5] { 4, 5, 6, 7, 8 };
    }

    private bool Contains(int[] arr, int value) {
      // Is an element in the array?
      foreach (int i in arr) {
        if (i == value) return true;
      }
      
      return false;
    }

    private int[] SubsetSubtract(int[] arr, int value) {
      // Remove a value from a set
      List<int> temp = new List<int>();
      foreach (int i in arr) {
        if (i == value) continue;
        temp.Add(i);
      }
      return temp.ToArray();
    }

    private int[] SubsetCombine(int[] arr, int value) {
      // Combine a set and a value
      List<int> temp = new List<int>();
      foreach (int i in arr) {
        temp.Add(i);
      }
      temp.Add(value);
      return temp.ToArray();
    }

    private int firstPosInN() {
      // Get the index of the first positive value in N
      foreach (int i in N) {
        if (c[i] > 0) return i;
      }
      return -1;
    }

    private double a_sub(int i, int e) {
      // API sugar to better match provided algorithm
      if (i < 0 || e < 0) return 0;
      else return A[i, e];
    }

    private double b_sub(int i) {
      // API sugar to better match provided algorithm
      if (i < 0) return 0;
      else return b[i];
    }

  }
}
