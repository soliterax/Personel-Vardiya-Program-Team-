using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Personel_Vardiya_Programı_Team_.SetupForm;

namespace Personel_Vardiya_Programı_Team_.Layouts.SystemScreens
{
    public partial class NobetMonitor : UserControl
    {
        public NobetMonitor()
        {
            InitializeComponent();
        }

        private void NobetMonitor_Load(object sender, EventArgs e)
        {
            try
            {
                int height = int.Parse(ConnectionMemory.conn.GetManager().GetData("select Count(date) from Nobet" + DateTime.Now.Month).Rows[0][0].ToString()) * 52;
                flowLayoutPanel1.AutoScrollMinSize = new Size(flowLayoutPanel1.AutoScrollMinSize.Width, height);
            }
            catch (Exception ex) { }
            finally
            {
                
                ControlEkle();
            }
        }

        Task ControlEkle()
        {
            return Task.Run(() =>
            {
                try
                {
                    DataTable dt = ConnectionMemory.conn.GetManager().GetData("select * from Nobet" + DateTime.Now.Month);

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            foreach (DataRow row in dt.Rows)
                            {
                                InfoUserControl c = new InfoUserControl(row);
                                flowLayoutPanel1.Controls.Add(c);
                            }
                        });
                    }
                } catch (Exception ex) { return; }
            });
        }
    }
}
