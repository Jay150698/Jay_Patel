using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Point = Tekla.Structures.Geometry3d.Point;

namespace Tekla1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            Model model = new Model();
            Beam beam1 = new Beam();
            for (int i = 0; i<k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Point point3 = new Point(j * 6000, i*6000, 0);
                    Point point4 = new Point(j * 6000, i*6000, 1000);

                    beam1.StartPoint = point3;
                    beam1.EndPoint = point4;
                    beam1.Profile.ProfileString = "ISMB300";
                    beam1.Material.MaterialString = "E295";
                    beam1.Position.Rotation = Position.RotationEnum.BELOW;
                    beam1.Class = "5";
                    beam1.Finish = "PAINT";
                    beam1.StartPointOffset = new Offset();
                    beam1.EndPointOffset = new Offset();
                    bool result = false;
                    result = beam1.Insert();
                    model.CommitChanges();
                }
            }
            //for (int i = 0; i < 2; i++)
            //{
            //    Point point3 = new Point(0, (i + 1) * 6000, 0);
            //    Point point4 = new Point(0, (i + 1) * 6000, 1000);
            //    beam1.StartPoint = point3;
            //    beam1.EndPoint = point4;
            //    beam1.Profile.ProfileString = "ISMB300";
            //    beam1.Material.MaterialString = "E295";
            //    beam1.Position.Rotation = Position.RotationEnum.BELOW;
            //    beam1.Class = "5";
            //    beam1.Finish = "PAINT";
            //    beam1.StartPointOffset = new Offset();
            //    beam1.EndPointOffset = new Offset();
            //    bool result = false;
            //    result = beam1.Insert();
            //    model.CommitChanges();
            //}

        }
    }
}
