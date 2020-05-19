namespace GymManagement
{
    partial class frm_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.btn_AddPlan = new System.Windows.Forms.Button();
            this.btn_ShowMembers = new System.Windows.Forms.Button();
            this.btn_Finances = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Gym";
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMember.Location = new System.Drawing.Point(34, 138);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(289, 42);
            this.btn_AddMember.TabIndex = 1;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // btn_AddPlan
            // 
            this.btn_AddPlan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPlan.Location = new System.Drawing.Point(34, 207);
            this.btn_AddPlan.Name = "btn_AddPlan";
            this.btn_AddPlan.Size = new System.Drawing.Size(289, 42);
            this.btn_AddPlan.TabIndex = 2;
            this.btn_AddPlan.Text = "Add Plan";
            this.btn_AddPlan.UseVisualStyleBackColor = true;
            this.btn_AddPlan.Click += new System.EventHandler(this.btn_AddPlan_Click);
            // 
            // btn_ShowMembers
            // 
            this.btn_ShowMembers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowMembers.Location = new System.Drawing.Point(34, 276);
            this.btn_ShowMembers.Name = "btn_ShowMembers";
            this.btn_ShowMembers.Size = new System.Drawing.Size(289, 42);
            this.btn_ShowMembers.TabIndex = 3;
            this.btn_ShowMembers.Text = "Show Members";
            this.btn_ShowMembers.UseVisualStyleBackColor = true;
            this.btn_ShowMembers.Click += new System.EventHandler(this.btn_ShowMembers_Click);
            // 
            // btn_Finances
            // 
            this.btn_Finances.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finances.Location = new System.Drawing.Point(34, 345);
            this.btn_Finances.Name = "btn_Finances";
            this.btn_Finances.Size = new System.Drawing.Size(289, 42);
            this.btn_Finances.TabIndex = 4;
            this.btn_Finances.Text = "Finances";
            this.btn_Finances.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(34, 414);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(289, 42);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 496);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Finances);
            this.Controls.Add(this.btn_ShowMembers);
            this.Controls.Add(this.btn_AddPlan);
            this.Controls.Add(this.btn_AddMember);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Gym";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddMember;
        private System.Windows.Forms.Button btn_AddPlan;
        private System.Windows.Forms.Button btn_ShowMembers;
        private System.Windows.Forms.Button btn_Finances;
        private System.Windows.Forms.Button btn_Exit;
    }
}

