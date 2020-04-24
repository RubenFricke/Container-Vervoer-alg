using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Container = ContainerVervoerClassLibrary.Models.Container;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace Container_Vervoer
{
    public partial class ContainerManagementForm : Form
    {
        private Ship ship;
        private ShipFiller filler;
        List<Container> unsortedContainers = new List<Container>();
        private Container[,,] solution;

        int shipLength;
        int shipWidth;
        int shipHeight;

        public ContainerManagementForm()
        {
            InitializeComponent();
        }

        private void bttn_SetShipConfiguration_Click(object sender, EventArgs e)
        {
            shipLength = Convert.ToInt32(nmrc_ShipLength.Value);
            shipWidth = Convert.ToInt32(nmrc_ShipWidth.Value);
            shipHeight = Convert.ToInt32(nmrc_ShipHeight.Value);

            ship = new Ship(shipLength, shipWidth, shipHeight);
            filler = new ShipFiller(ship);

            txtbx_Log.Text += $"Ship configured with length={shipLength}, width={shipWidth}, height={shipHeight}" +
                              Environment.NewLine;
        }

        private void bttn_SortContainers_Click(object sender, EventArgs e)
        {
            if (filler == null)
            {
                MessageBox.Show("Configure the ship first");
                txtbx_Log.Text += $"To sort containers, you need to configure the ship first!" + Environment.NewLine;
            }
            else if (unsortedContainers.Count <= 0)
            {
                MessageBox.Show("Add containers first");
                txtbx_Log.Text += $"To sort containers, you need to add containers to sort!" + Environment.NewLine;
            }
            else
            {
                try
                {
                    ship = new Ship(ship.Dimensions.Length, ship.Dimensions.Width, ship.Dimensions.Heigth);
                    filler = new ShipFiller(ship);

                    solution = filler.SortContainers(unsortedContainers);
                    updateSolutionOutput();
                    txtbx_Log.Text += $"The containers are ordered" + Environment.NewLine;
                    lbl_BalanceShip.Text = ship.Balance.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    txtbx_Log.Text += $"Something went wrong! {exception.Message}" + Environment.NewLine;
                }
            }
        }

        private void bttn_AddContainers_Click(object sender, EventArgs e)
        {
            Type containerType = getContainerType();
            int containerWeight = Convert.ToInt32(nmrc_ContainerWeight.Value);

            for (int i = 0; i < nmrc_TotalContainersToAdd.Value; i++)
            {
                try
                {
                    unsortedContainers.Add(new Container(containerWeight, containerType));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            updateContainerOverview();
        }

        private void updateContainerOverview()
        {
            lstbx_containers.Items.Clear();
            foreach (var container in unsortedContainers)
            {
                lstbx_containers.Items.Add(container);
            }
        }

        private Type getContainerType()
        {
            if (rdbttn_Cooled.Checked)
                return Type.Cooled;
            else if (rdbttn_Standard.Checked)
                return Type.Standard;
            else if (rdbttn_Valuable.Checked)
                return Type.Valuable;

            return Type.Standard;
        }

        private void bttn_RemoveContainer_Click(object sender, EventArgs e)
        {
            Container containerToRemove = (Container)lstbx_containers.SelectedItem;
            unsortedContainers.Remove(containerToRemove);
            updateContainerOverview();
        }

        private void bttn_ClearContainers_Click(object sender, EventArgs e)
        {
            unsortedContainers.Clear();
            updateContainerOverview();
        }

        private void updateSolutionOutput()
        {
            txtbx_SortedContainers.Text = string.Empty;
            for (int l = 0; l < ship.Dimensions.Length; l++)
            {
                for (int w = 0; w < ship.Dimensions.Width; w++)
                {
                    for (int h = 0; h < ship.Dimensions.Heigth; h++)
                    {
                        txtbx_SortedContainers.Text += $"[{l},{w},{h}] - {solution[l, w, h]}" + Environment.NewLine;
                    }
                }
            }
        }
    }
}
