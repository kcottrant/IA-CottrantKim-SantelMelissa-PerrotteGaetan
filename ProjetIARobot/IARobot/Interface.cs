using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IARobot
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            tableauRobot.BorderStyle = BorderStyle.FixedSingle;
            tableauRobot.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            this.tableauRobot.CellPaint += tableauRobot_Paint;

        }

        private void tableauRobot_Paint(object sender, TableLayoutCellPaintEventArgs e)
        {
           
            if (e.Row == 0)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                if(e.Row==19)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                if(e.Column==0)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                if(e.Column==19)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            for(int i=3;i<=8;i++)
            {
                if(e.Row==i && ( e.Column==4 || e.Column==5))
                     e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            for (int i = 11; i <= 15; i++)
            {
                if (e.Row == i && (e.Column == 5 || e.Column == 6))
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            for (int i = 14; i <= 19; i++)
            {
                if (e.Row == i && (e.Column == 10 || e.Column == 11))
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            for (int i = 12; i <= 16; i++)
            {
                if (e.Row == i && (e.Column == 15 || e.Column == 16))
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }

            for (int i = 0; i <= 11; i++)
            {
                if (e.Row == i && e.Column == 9)
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            for (int i = 0; i <= 4; i++)
            {
                if (e.Row == i && e.Column == 15)
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            if(e.Row==11 && e.Column==8)
                e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            for (int i = 0; i <= 6; i++)
            {
                if (e.Row == 11 && e.Column == i)
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }
            for (int i = 15; i <= 19; i++)
            {
                if (e.Row == 4 && e.Column == i)
                    e.Graphics.FillRectangle(Brushes.Black, e.CellBounds);
            }

            if (e.Row == 3 && e.Column == 2)
              e.Graphics.DrawImage(Image.FromFile("H:\\IA\\IA-CottrantKim-SantelMelissa-PerrotteGaetan\\ProjetIARobot\\roboto-logo.png"), e.CellBounds);
            if (e.Row == 16 && e.Column == 17)
                e.Graphics.DrawImage(Image.FromFile("H:\\IA\\IA-CottrantKim-SantelMelissa-PerrotteGaetan\\ProjetIARobot\\door.png"), e.CellBounds);


        }
    }
}
