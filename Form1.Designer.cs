namespace Praktikum_AD_Week_14
{
    partial class PraktikumADWeek13
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblScorer = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblWorstDiscipline = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.lblNamaStadium = new System.Windows.Forms.Label();
            this.lblNamaManager = new System.Windows.Forms.Label();
            this.lblNamaTeam = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(142, 27);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 65);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(243, 27);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(95, 65);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(344, 27);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 65);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(445, 27);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 65);
            this.btnLast.TabIndex = 3;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(80, 124);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(103, 20);
            this.lblTeam.TabIndex = 4;
            this.lblTeam.Text = "Team Name :";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(80, 160);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(80, 20);
            this.lblManager.TabIndex = 5;
            this.lblManager.Text = "Manager :";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(80, 196);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(76, 20);
            this.lblStadium.TabIndex = 6;
            this.lblStadium.Text = "Stadium :";
            // 
            // lblScorer
            // 
            this.lblScorer.AutoSize = true;
            this.lblScorer.Location = new System.Drawing.Point(80, 230);
            this.lblScorer.Name = "lblScorer";
            this.lblScorer.Size = new System.Drawing.Size(95, 20);
            this.lblScorer.TabIndex = 7;
            this.lblScorer.Text = "Top Scorer :";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(80, 268);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(130, 20);
            this.lblDiscipline.TabIndex = 8;
            this.lblDiscipline.Text = "Worst Discipline :";
            // 
            // lblWorstDiscipline
            // 
            this.lblWorstDiscipline.AutoSize = true;
            this.lblWorstDiscipline.Location = new System.Drawing.Point(239, 268);
            this.lblWorstDiscipline.Name = "lblWorstDiscipline";
            this.lblWorstDiscipline.Size = new System.Drawing.Size(21, 20);
            this.lblWorstDiscipline.TabIndex = 13;
            this.lblWorstDiscipline.Text = "...";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Location = new System.Drawing.Point(239, 230);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(21, 20);
            this.lblTopScorer.TabIndex = 12;
            this.lblTopScorer.Text = "...";
            // 
            // lblNamaStadium
            // 
            this.lblNamaStadium.AutoSize = true;
            this.lblNamaStadium.Location = new System.Drawing.Point(239, 196);
            this.lblNamaStadium.Name = "lblNamaStadium";
            this.lblNamaStadium.Size = new System.Drawing.Size(21, 20);
            this.lblNamaStadium.TabIndex = 11;
            this.lblNamaStadium.Text = "...";
            // 
            // lblNamaManager
            // 
            this.lblNamaManager.AutoSize = true;
            this.lblNamaManager.Location = new System.Drawing.Point(239, 160);
            this.lblNamaManager.Name = "lblNamaManager";
            this.lblNamaManager.Size = new System.Drawing.Size(21, 20);
            this.lblNamaManager.TabIndex = 10;
            this.lblNamaManager.Text = "...";
            // 
            // lblNamaTeam
            // 
            this.lblNamaTeam.AutoSize = true;
            this.lblNamaTeam.Location = new System.Drawing.Point(239, 124);
            this.lblNamaTeam.Name = "lblNamaTeam";
            this.lblNamaTeam.Size = new System.Drawing.Size(21, 20);
            this.lblNamaTeam.TabIndex = 9;
            this.lblNamaTeam.Text = "...";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(48, 333);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersWidth = 62;
            this.dgvDetail.RowTemplate.Height = 28;
            this.dgvDetail.Size = new System.Drawing.Size(586, 276);
            this.dgvDetail.TabIndex = 14;
            // 
            // PraktikumADWeek13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 635);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.lblWorstDiscipline);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblNamaStadium);
            this.Controls.Add(this.lblNamaManager);
            this.Controls.Add(this.lblNamaTeam);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.lblScorer);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Name = "PraktikumADWeek13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblScorer;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblWorstDiscipline;
        private System.Windows.Forms.Label lblTopScorer;
        private System.Windows.Forms.Label lblNamaStadium;
        private System.Windows.Forms.Label lblNamaManager;
        private System.Windows.Forms.Label lblNamaTeam;
        private System.Windows.Forms.DataGridView dgvDetail;
    }
}

