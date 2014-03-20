namespace WindowsFormsApplication1 {
  partial class Simplex {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.copper = new System.Windows.Forms.Label();
      this.copperResult = new System.Windows.Forms.TextBox();
      this.gold = new System.Windows.Forms.Label();
      this.goldResult = new System.Windows.Forms.TextBox();
      this.silver = new System.Windows.Forms.Label();
      this.silverResult = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.platinumResult = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.maxResults = new System.Windows.Forms.TextBox();
      this.solve = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // copper
      // 
      this.copper.AutoSize = true;
      this.copper.Location = new System.Drawing.Point(13, 54);
      this.copper.Name = "copper";
      this.copper.Size = new System.Drawing.Size(41, 13);
      this.copper.TabIndex = 0;
      this.copper.Text = "Copper";
      // 
      // copperResult
      // 
      this.copperResult.Location = new System.Drawing.Point(60, 51);
      this.copperResult.Name = "copperResult";
      this.copperResult.Size = new System.Drawing.Size(379, 20);
      this.copperResult.TabIndex = 1;
      // 
      // gold
      // 
      this.gold.AutoSize = true;
      this.gold.Location = new System.Drawing.Point(16, 106);
      this.gold.Name = "gold";
      this.gold.Size = new System.Drawing.Size(29, 13);
      this.gold.TabIndex = 2;
      this.gold.Text = "Gold";
      // 
      // goldResult
      // 
      this.goldResult.Location = new System.Drawing.Point(60, 103);
      this.goldResult.Name = "goldResult";
      this.goldResult.Size = new System.Drawing.Size(379, 20);
      this.goldResult.TabIndex = 3;
      // 
      // silver
      // 
      this.silver.AutoSize = true;
      this.silver.Location = new System.Drawing.Point(16, 80);
      this.silver.Name = "silver";
      this.silver.Size = new System.Drawing.Size(33, 13);
      this.silver.TabIndex = 4;
      this.silver.Text = "Silver";
      // 
      // silverResult
      // 
      this.silverResult.Location = new System.Drawing.Point(60, 77);
      this.silverResult.Name = "silverResult";
      this.silverResult.Size = new System.Drawing.Size(379, 20);
      this.silverResult.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 133);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Platinum";
      // 
      // platinumResult
      // 
      this.platinumResult.Location = new System.Drawing.Point(60, 130);
      this.platinumResult.Name = "platinumResult";
      this.platinumResult.Size = new System.Drawing.Size(379, 20);
      this.platinumResult.TabIndex = 7;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(68, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "MAX VALUE";
      // 
      // maxResults
      // 
      this.maxResults.Location = new System.Drawing.Point(87, 12);
      this.maxResults.Name = "maxResults";
      this.maxResults.Size = new System.Drawing.Size(352, 20);
      this.maxResults.TabIndex = 9;
      // 
      // solve
      // 
      this.solve.Location = new System.Drawing.Point(363, 160);
      this.solve.Name = "solve";
      this.solve.Size = new System.Drawing.Size(75, 23);
      this.solve.TabIndex = 10;
      this.solve.Text = "Solve";
      this.solve.UseVisualStyleBackColor = true;
      this.solve.Click += new System.EventHandler(this.button1_Click);
      // 
      // Simplex
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(452, 195);
      this.Controls.Add(this.solve);
      this.Controls.Add(this.maxResults);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.platinumResult);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.silverResult);
      this.Controls.Add(this.silver);
      this.Controls.Add(this.goldResult);
      this.Controls.Add(this.gold);
      this.Controls.Add(this.copperResult);
      this.Controls.Add(this.copper);
      this.Name = "Simplex";
      this.Text = "Simplex Solver";
      this.Load += new System.EventHandler(this.Simplex_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label copper;
    private System.Windows.Forms.TextBox copperResult;
    private System.Windows.Forms.Label gold;
    private System.Windows.Forms.TextBox goldResult;
    private System.Windows.Forms.Label silver;
    private System.Windows.Forms.TextBox silverResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox platinumResult;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox maxResults;
    private System.Windows.Forms.Button solve;
  }
}

