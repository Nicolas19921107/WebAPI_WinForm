using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using WebAPI.Models;

namespace WinForm
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NameOne = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeOne = new System.Windows.Forms.TextBox();
            this.AgeTwo = new System.Windows.Forms.TextBox();
            this.NameTwo = new System.Windows.Forms.TextBox();
            this.AgeThr = new System.Windows.Forms.TextBox();
            this.NameThr = new System.Windows.Forms.TextBox();
            this.AgeFour = new System.Windows.Forms.TextBox();
            this.NameFour = new System.Windows.Forms.TextBox();
            this.ModelBindObjURL = new System.Windows.Forms.TextBox();
            this.ModelBindObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjTitle = new System.Windows.Forms.Label();
            this.SimpleModelBindingTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjTitle = new System.Windows.Forms.Label();
            this.ModelBindObjJSON = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JSON = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Urlencoded = new System.Windows.Forms.Label();
            this.SimpleBindingJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingTItle = new System.Windows.Forms.Label();
            this.SimpleBindingURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBindingArrayJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjURL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjURL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SimpleModelBindingJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindingURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(844, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameOne
            // 
            this.NameOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameOne.Location = new System.Drawing.Point(104, 23);
            this.NameOne.Multiline = true;
            this.NameOne.Name = "NameOne";
            this.NameOne.Size = new System.Drawing.Size(179, 38);
            this.NameOne.TabIndex = 13;
            this.NameOne.TextChanged += new System.EventHandler(this.NameOne_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.LightBlue;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(12, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 37);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "姓名";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.LightBlue;
            this.AgeLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeLabel.Location = new System.Drawing.Point(12, 76);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 37);
            this.AgeLabel.TabIndex = 15;
            this.AgeLabel.Text = "年齡";
            // 
            // AgeOne
            // 
            this.AgeOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeOne.Location = new System.Drawing.Point(104, 75);
            this.AgeOne.Multiline = true;
            this.AgeOne.Name = "AgeOne";
            this.AgeOne.Size = new System.Drawing.Size(179, 38);
            this.AgeOne.TabIndex = 16;
            // 
            // AgeTwo
            // 
            this.AgeTwo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeTwo.Location = new System.Drawing.Point(289, 75);
            this.AgeTwo.Multiline = true;
            this.AgeTwo.Name = "AgeTwo";
            this.AgeTwo.Size = new System.Drawing.Size(179, 38);
            this.AgeTwo.TabIndex = 18;
            // 
            // NameTwo
            // 
            this.NameTwo.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTwo.Location = new System.Drawing.Point(289, 23);
            this.NameTwo.Multiline = true;
            this.NameTwo.Name = "NameTwo";
            this.NameTwo.Size = new System.Drawing.Size(179, 38);
            this.NameTwo.TabIndex = 17;
            // 
            // AgeThr
            // 
            this.AgeThr.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeThr.Location = new System.Drawing.Point(474, 75);
            this.AgeThr.Multiline = true;
            this.AgeThr.Name = "AgeThr";
            this.AgeThr.Size = new System.Drawing.Size(179, 38);
            this.AgeThr.TabIndex = 20;
            // 
            // NameThr
            // 
            this.NameThr.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameThr.Location = new System.Drawing.Point(474, 23);
            this.NameThr.Multiline = true;
            this.NameThr.Name = "NameThr";
            this.NameThr.Size = new System.Drawing.Size(179, 38);
            this.NameThr.TabIndex = 19;
            // 
            // AgeFour
            // 
            this.AgeFour.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeFour.Location = new System.Drawing.Point(659, 74);
            this.AgeFour.Multiline = true;
            this.AgeFour.Name = "AgeFour";
            this.AgeFour.Size = new System.Drawing.Size(179, 38);
            this.AgeFour.TabIndex = 22;
            // 
            // NameFour
            // 
            this.NameFour.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameFour.Location = new System.Drawing.Point(659, 22);
            this.NameFour.Multiline = true;
            this.NameFour.Name = "NameFour";
            this.NameFour.Size = new System.Drawing.Size(179, 38);
            this.NameFour.TabIndex = 21;
            // 
            // ModelBindObjURL
            // 
            this.ModelBindObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjURL.Location = new System.Drawing.Point(328, 362);
            this.ModelBindObjURL.Multiline = true;
            this.ModelBindObjURL.Name = "ModelBindObjURL";
            this.ModelBindObjURL.ReadOnly = true;
            this.ModelBindObjURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindObjURL.TabIndex = 23;
            this.ModelBindObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindObjTitle
            // 
            this.ModelBindObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjTitle.Location = new System.Drawing.Point(12, 362);
            this.ModelBindObjTitle.Name = "ModelBindObjTitle";
            this.ModelBindObjTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindObjTitle.TabIndex = 24;
            this.ModelBindObjTitle.Text = "ModelBindingObj";
            this.ModelBindObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayTitle
            // 
            this.ModelBindingArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayTitle.Location = new System.Drawing.Point(612, 136);
            this.ModelBindingArrayTitle.Name = "ModelBindingArrayTitle";
            this.ModelBindingArrayTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindingArrayTitle.TabIndex = 26;
            this.ModelBindingArrayTitle.Text = "ModelBindingArray";
            this.ModelBindingArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjTitle
            // 
            this.ModelBindingNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjTitle.Location = new System.Drawing.Point(612, 362);
            this.ModelBindingNestedObjTitle.Name = "ModelBindingNestedObjTitle";
            this.ModelBindingNestedObjTitle.Size = new System.Drawing.Size(185, 213);
            this.ModelBindingNestedObjTitle.TabIndex = 28;
            this.ModelBindingNestedObjTitle.Text = "ModelBindingNestedObj";
            this.ModelBindingNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindingTitle
            // 
            this.SimpleModelBindingTitle.BackColor = System.Drawing.Color.Orange;
            this.SimpleModelBindingTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindingTitle.Location = new System.Drawing.Point(14, 585);
            this.SimpleModelBindingTitle.Name = "SimpleModelBindingTitle";
            this.SimpleModelBindingTitle.Size = new System.Drawing.Size(185, 200);
            this.SimpleModelBindingTitle.TabIndex = 30;
            this.SimpleModelBindingTitle.Text = "SimpleModelBinding";
            this.SimpleModelBindingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjTitle
            // 
            this.ModelBindingArrayNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjTitle.Location = new System.Drawing.Point(612, 583);
            this.ModelBindingArrayNestedObjTitle.Name = "ModelBindingArrayNestedObjTitle";
            this.ModelBindingArrayNestedObjTitle.Size = new System.Drawing.Size(185, 202);
            this.ModelBindingArrayNestedObjTitle.TabIndex = 32;
            this.ModelBindingArrayNestedObjTitle.Text = "ModelBindingArrayNestedObj";
            this.ModelBindingArrayNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindObjJSON
            // 
            this.ModelBindObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjJSON.Location = new System.Drawing.Point(328, 471);
            this.ModelBindObjJSON.Multiline = true;
            this.ModelBindObjJSON.Name = "ModelBindObjJSON";
            this.ModelBindObjJSON.ReadOnly = true;
            this.ModelBindObjJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindObjJSON.TabIndex = 33;
            this.ModelBindObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(203, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 103);
            this.label2.TabIndex = 34;
            this.label2.Text = "Urlencoded";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JSON
            // 
            this.JSON.BackColor = System.Drawing.Color.SkyBlue;
            this.JSON.Enabled = false;
            this.JSON.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JSON.Location = new System.Drawing.Point(203, 471);
            this.JSON.Name = "JSON";
            this.JSON.Size = new System.Drawing.Size(119, 104);
            this.JSON.TabIndex = 35;
            this.JSON.Text = "JSON";
            this.JSON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(203, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 104);
            this.label1.TabIndex = 40;
            this.label1.Text = "JSON";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urlencoded
            // 
            this.Urlencoded.BackColor = System.Drawing.Color.SkyBlue;
            this.Urlencoded.Enabled = false;
            this.Urlencoded.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Urlencoded.Location = new System.Drawing.Point(203, 136);
            this.Urlencoded.Name = "Urlencoded";
            this.Urlencoded.Size = new System.Drawing.Size(119, 103);
            this.Urlencoded.TabIndex = 39;
            this.Urlencoded.Text = "Urlencoded";
            this.Urlencoded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingJSON
            // 
            this.SimpleBindingJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingJSON.Location = new System.Drawing.Point(328, 245);
            this.SimpleBindingJSON.Multiline = true;
            this.SimpleBindingJSON.Name = "SimpleBindingJSON";
            this.SimpleBindingJSON.ReadOnly = true;
            this.SimpleBindingJSON.Size = new System.Drawing.Size(269, 104);
            this.SimpleBindingJSON.TabIndex = 38;
            this.SimpleBindingJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingTItle
            // 
            this.SimpleBindingTItle.BackColor = System.Drawing.Color.Orange;
            this.SimpleBindingTItle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingTItle.Location = new System.Drawing.Point(12, 136);
            this.SimpleBindingTItle.Name = "SimpleBindingTItle";
            this.SimpleBindingTItle.Size = new System.Drawing.Size(185, 213);
            this.SimpleBindingTItle.TabIndex = 37;
            this.SimpleBindingTItle.Text = "SimpleBinding";
            this.SimpleBindingTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingURL
            // 
            this.SimpleBindingURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingURL.Location = new System.Drawing.Point(328, 136);
            this.SimpleBindingURL.Multiline = true;
            this.SimpleBindingURL.Name = "SimpleBindingURL";
            this.SimpleBindingURL.ReadOnly = true;
            this.SimpleBindingURL.Size = new System.Drawing.Size(269, 103);
            this.SimpleBindingURL.TabIndex = 36;
            this.SimpleBindingURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(805, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 104);
            this.label3.TabIndex = 44;
            this.label3.Text = "JSON";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(803, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 103);
            this.label4.TabIndex = 43;
            this.label4.Text = "Urlencoded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayJSON
            // 
            this.ModelBindingArrayJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayJSON.Location = new System.Drawing.Point(928, 245);
            this.ModelBindingArrayJSON.Multiline = true;
            this.ModelBindingArrayJSON.Name = "ModelBindingArrayJSON";
            this.ModelBindingArrayJSON.ReadOnly = true;
            this.ModelBindingArrayJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindingArrayJSON.TabIndex = 42;
            this.ModelBindingArrayJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayURL
            // 
            this.ModelBindingArrayURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayURL.Location = new System.Drawing.Point(928, 136);
            this.ModelBindingArrayURL.Multiline = true;
            this.ModelBindingArrayURL.Name = "ModelBindingArrayURL";
            this.ModelBindingArrayURL.ReadOnly = true;
            this.ModelBindingArrayURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindingArrayURL.TabIndex = 41;
            this.ModelBindingArrayURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(803, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 104);
            this.label5.TabIndex = 48;
            this.label5.Text = "JSON";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(803, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 103);
            this.label6.TabIndex = 47;
            this.label6.Text = "Urlencoded";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjJSON
            // 
            this.ModelBindingNestedObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjJSON.Location = new System.Drawing.Point(928, 471);
            this.ModelBindingNestedObjJSON.Multiline = true;
            this.ModelBindingNestedObjJSON.Name = "ModelBindingNestedObjJSON";
            this.ModelBindingNestedObjJSON.ReadOnly = true;
            this.ModelBindingNestedObjJSON.Size = new System.Drawing.Size(269, 104);
            this.ModelBindingNestedObjJSON.TabIndex = 46;
            this.ModelBindingNestedObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjURL
            // 
            this.ModelBindingNestedObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjURL.Location = new System.Drawing.Point(928, 362);
            this.ModelBindingNestedObjURL.Multiline = true;
            this.ModelBindingNestedObjURL.Name = "ModelBindingNestedObjURL";
            this.ModelBindingNestedObjURL.ReadOnly = true;
            this.ModelBindingNestedObjURL.Size = new System.Drawing.Size(269, 103);
            this.ModelBindingNestedObjURL.TabIndex = 45;
            this.ModelBindingNestedObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(803, 688);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 97);
            this.label7.TabIndex = 52;
            this.label7.Text = "JSON";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(803, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 97);
            this.label8.TabIndex = 51;
            this.label8.Text = "Urlencoded";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjJSON
            // 
            this.ModelBindingArrayNestedObjJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjJSON.Location = new System.Drawing.Point(928, 688);
            this.ModelBindingArrayNestedObjJSON.Multiline = true;
            this.ModelBindingArrayNestedObjJSON.Name = "ModelBindingArrayNestedObjJSON";
            this.ModelBindingArrayNestedObjJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjJSON.Size = new System.Drawing.Size(269, 97);
            this.ModelBindingArrayNestedObjJSON.TabIndex = 50;
            this.ModelBindingArrayNestedObjJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjURL
            // 
            this.ModelBindingArrayNestedObjURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjURL.Location = new System.Drawing.Point(928, 585);
            this.ModelBindingArrayNestedObjURL.Multiline = true;
            this.ModelBindingArrayNestedObjURL.Name = "ModelBindingArrayNestedObjURL";
            this.ModelBindingArrayNestedObjURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjURL.Size = new System.Drawing.Size(269, 97);
            this.ModelBindingArrayNestedObjURL.TabIndex = 49;
            this.ModelBindingArrayNestedObjURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(205, 688);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 97);
            this.label9.TabIndex = 56;
            this.label9.Text = "JSON";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SkyBlue;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(205, 585);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 97);
            this.label10.TabIndex = 55;
            this.label10.Text = "Urlencoded";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindingJSON
            // 
            this.SimpleModelBindingJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindingJSON.Location = new System.Drawing.Point(328, 688);
            this.SimpleModelBindingJSON.Multiline = true;
            this.SimpleModelBindingJSON.Name = "SimpleModelBindingJSON";
            this.SimpleModelBindingJSON.ReadOnly = true;
            this.SimpleModelBindingJSON.Size = new System.Drawing.Size(269, 97);
            this.SimpleModelBindingJSON.TabIndex = 54;
            this.SimpleModelBindingJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindingURL
            // 
            this.SimpleModelBindingURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindingURL.Location = new System.Drawing.Point(328, 585);
            this.SimpleModelBindingURL.Multiline = true;
            this.SimpleModelBindingURL.Name = "SimpleModelBindingURL";
            this.SimpleModelBindingURL.ReadOnly = true;
            this.SimpleModelBindingURL.Size = new System.Drawing.Size(269, 97);
            this.SimpleModelBindingURL.TabIndex = 53;
            this.SimpleModelBindingURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(1224, 808);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SimpleModelBindingJSON);
            this.Controls.Add(this.SimpleModelBindingURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModelBindingArrayNestedObjJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModelBindingNestedObjJSON);
            this.Controls.Add(this.ModelBindingNestedObjURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBindingArrayJSON);
            this.Controls.Add(this.ModelBindingArrayURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urlencoded);
            this.Controls.Add(this.SimpleBindingJSON);
            this.Controls.Add(this.SimpleBindingTItle);
            this.Controls.Add(this.SimpleBindingURL);
            this.Controls.Add(this.JSON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModelBindObjJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjTitle);
            this.Controls.Add(this.SimpleModelBindingTitle);
            this.Controls.Add(this.ModelBindingNestedObjTitle);
            this.Controls.Add(this.ModelBindingArrayTitle);
            this.Controls.Add(this.ModelBindObjTitle);
            this.Controls.Add(this.ModelBindObjURL);
            this.Controls.Add(this.AgeFour);
            this.Controls.Add(this.NameFour);
            this.Controls.Add(this.AgeThr);
            this.Controls.Add(this.NameThr);
            this.Controls.Add(this.AgeTwo);
            this.Controls.Add(this.NameTwo);
            this.Controls.Add(this.AgeOne);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameOne);
            this.Controls.Add(this.button1);
            this.Name = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ForFunc DoFunc = new ForFunc();
            string[] NameInput = { NameOne.Text, NameTwo.Text, NameThr.Text, NameFour.Text };
            string[] AgeInput = { AgeOne.Text, AgeTwo.Text, AgeThr.Text, AgeFour.Text };
            List<string> Name = new List<string>();
            List<string> Age = new List<string>();
            for(int i=0;i<NameInput.Length;i++)
            {
                if(!string.IsNullOrEmpty(NameInput[i])&&!string.IsNullOrEmpty(AgeInput[i]))
                {
                    Name.Add(NameInput[i]);
                    Age.Add(AgeInput[i]);
                }
                else
                {
                    continue;
                }
            }

     
            //SimpleBinding
            SimpleBinding(CreateNewDic(Name, Age),DoFunc);

            //ModelBinObj
            ModelBindObj(Name, Age,DoFunc);

            ////SimpleModelBindArray
            //SimpleModelBindingArray(CreateNewDic(Name, Age), Age);

            ////ModelBindingArray
            //ModelBindingArray(Name, Age);

            ////ModelBindingNestedObj
            //ModelBindingNestedObj(Name, Age);

            ////ModelBindingArrayNestedObj
            //ModelBindingArrayNestedObj(Name, Age);


        }

        private async void SimpleBinding(Dictionary<string,string> formDataDic,ForFunc DoFunc)
        {

                try
                {
                    //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                    //var formData = new FormUrlEncodedContent(formDataDic);
                    //HttpResponseMessage responseSimpleModelBinding = await client.PostAsync("https://localhost:44376/api/Home/SimpleBinding", formData);
                    //responseSimpleModelBinding.EnsureSuccessStatusCode();
                    //string ResponseBodySimpleModelBinding = await responseSimpleModelBinding.Content.ReadAsStringAsync();
                    Uri BaseURL=new Uri("https://localhost:44376/api/Home/SimpleBinding");
                    SimpleBindingURL.Text = await DoFunc.SendinUrlEncoded(formDataDic,BaseURL);


                    //Human data = new Human();
                    //data.Name = formDataDic["Name"];
                    //data.Age = Int32.Parse(formDataDic["Age"]);
                    //string JSON = JsonConvert.SerializeObject(data);
                    //HttpContent PostContentModelBindObj = new StringContent(JSON, Encoding.UTF8, "application/json");
                    //HttpResponseMessage responseModelBindObj = await client.PostAsync("https://localhost:44376/api/Home/SimpleBinding", PostContentModelBindObj);
                    //responseModelBindObj.EnsureSuccessStatusCode();
                    //string ResponseBodyModelBindObj = await responseModelBindObj.Content.ReadAsStringAsync();
                    //SimpleBindingJSON.Text = ResponseBodyModelBindObj;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
        
        }

        private async void ModelBindObj(List<string> Name, List<string> Age, ForFunc DoFunc)
        {   
            using(HttpClient client =new HttpClient())
            {
                try
                {
                    Human data = new Human();
                    data.Name = Name[0];
                    data.Age = Int32.Parse(Age[0]);
                    Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindObj");
                    ModelBindObjJSON.Text = await DoFunc.SendinJSON(data, BaseURL);

                    //Human data = new Human();
                    //data.Name = Name;
                    //data.Age = Int32.Parse(Age);
                    //string JSON = JsonConvert.SerializeObject(data);
                    //HttpContent PostContentModelBindObj = new StringContent(JSON, Encoding.UTF8, "application/json");
                    //HttpResponseMessage responseModelBindObj = await client.PostAsync("https://localhost:44376/api/Home/ModelBindObj", PostContentModelBindObj);
                    //responseModelBindObj.EnsureSuccessStatusCode();
                    //string ResponseBodyModelBindObj = await responseModelBindObj.Content.ReadAsStringAsync();
                    //ModelBindObjJSON.Text = ResponseBodyModelBindObj;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
        }

        private async void SimpleModelBindingArray(Dictionary<string, string> formDataDic,List<string>Age)
        {
            using(HttpClient client=new HttpClient())
            {
                try
                {
                    string param = "";
                    for (int i = 0; i < Age.Count; i++)
                    {
                        param += $"Age[]={Age[i]}";
                    }
                    var formData = new FormUrlEncodedContent(formDataDic);
                    //string param = $"Age[]={Age[0]}&Age[]={Age[1]}";
                    HttpResponseMessage responseSimpleModelBindArray = await client.PostAsync("https://localhost:44376/api/Home/SimpleModelBindArray?" + param, formData);
                    responseSimpleModelBindArray.EnsureSuccessStatusCode();
                    string ResponseBodySimpleModelBindArray = await responseSimpleModelBindArray.Content.ReadAsStringAsync();
                    SimpleModelBindingURL.Text = ResponseBodySimpleModelBindArray;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }

        }

        private async void ModelBindingArray(List<string>Name,List<string> Age)
        {
            using(HttpClient client=new HttpClient())
            {
                try
                {
                    List<Human> dataList = new List<Human>();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Human T = new Human();
                        T.Name = Name[i];
                        T.Age = Int32.Parse(Age[i]);
                        dataList.Add(T);
                    }
                    var JSON = JsonConvert.SerializeObject(dataList);
                    HttpContent PostContentModelBindingArray = new StringContent(JSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseModelBindingArray = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingArray", PostContentModelBindingArray);
                    responseModelBindingArray.EnsureSuccessStatusCode();
                    string ResponseBodyModelBindingArray = await responseModelBindingArray.Content.ReadAsStringAsync();
                    ModelBindingArrayJSON.Text = ResponseBodyModelBindingArray;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
        }

        private async void ModelBindingNestedObj(List<string> Name, List<string> Age)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Person dataP = new Person();
                    List<Person> F = new List<Person>();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Person Friends = new Person();
                        Friends.Name = Name[i];
                        Friends.Age = Int32.Parse(Age[i]);
                        F.Add(Friends);
                        dataP.Friends = F;
                    }

                    var JSON = JsonConvert.SerializeObject(dataP);
                    HttpContent PostContentModelBindingNestedObj = new StringContent(JSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseModelBindingNestedObj = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingNestedObj", PostContentModelBindingNestedObj);
                    responseModelBindingNestedObj.EnsureSuccessStatusCode();
                    string ResponseBodyModelBindingNestedObj = await responseModelBindingNestedObj.Content.ReadAsStringAsync();
                    ModelBindingNestedObjJSON.Text = ResponseBodyModelBindingNestedObj;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
        }

        private async void ModelBindingArrayNestedObj(List<string> Name, List<string> Age)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    List<Person> A = new List<Person>();
                    List<Person> F = new List<Person>();
                    Person dataQ = new Person();
                    for (int i = 0; i < Name.Count; i++)
                    {
                        Person Friends = new Person();
                        Friends.Name = Name[i];
                        Friends.Age = Int32.Parse(Age[i]);
                        F.Add(Friends);
                        dataQ.Friends = F;
                    }
                    A.Add(dataQ);
                    var JSON = JsonConvert.SerializeObject(A);
                    HttpContent PostContentModelBindingArrayNestedObj = new StringContent(JSON, Encoding.UTF8, "application/json");
                    HttpResponseMessage responseModelBindingArrayNestedObj = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingArrayNestedObj", PostContentModelBindingArrayNestedObj);
                    responseModelBindingArrayNestedObj.EnsureSuccessStatusCode();
                    string ResponseBodyModelBindingArrayNestedObj = await responseModelBindingArrayNestedObj.Content.ReadAsStringAsync();
                    ModelBindingArrayNestedObjJSON.Text = ResponseBodyModelBindingArrayNestedObj;
                }
                catch (Exception error)
                {
                    Console.WriteLine("{0}", error.Message);
                }
            }
        }

        private string ArrayHandle(List<string> Name)
        {
            string NameArr = "";
            foreach (var item in Name)
            {
                NameArr += item + ",";
            }
            return NameArr;
        }
        private Dictionary<string, string> CreateNewDic(List<string> Name, List<string> Age)
        {
            if (Name.Count > 1)
            {
                Dictionary<string, string> formDataDic = new Dictionary<string, string>()
                {
                    [""] = ArrayHandle(Name),
                };
                return formDataDic;
            }
            else
            {
                Dictionary<string, string> formDataDic = new Dictionary<string, string>()
                {
                    [nameof(Name)] = Name[0],
                    [nameof(Age)] = Age[0],
                };
                return formDataDic;
            }
        }




        private void WinForm_Load_1(object sender, EventArgs e)
        {

        }

        private void NameOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
