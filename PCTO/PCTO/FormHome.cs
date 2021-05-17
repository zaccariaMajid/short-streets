﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCTO
{
    partial class FormHome : Form
    {
        FormShortStreets fShortStreets;
        public FormHome(FormShortStreets f)
        {
            InitializeComponent();
            fShortStreets = f;
            lblMinCoordinates.Text = $"Min coordinates: {f.coordinatesRange.MinCoordinates.Lat}, {f.coordinatesRange.MinCoordinates.Lng}";
            lblMaxCoordinates.Text = $"Max coordinates: {f.coordinatesRange.MaxCoordinates.Lat}, {f.coordinatesRange.MaxCoordinates.Lng}";
        }
        static ApiCaller caller = new ApiCaller();
        CoordinateHelper helper = new CoordinateHelper(caller);
        static IList<Address> previousAddresses = new List<Address>();
        bool IsValidAddress;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCurNumber.Text) ||
                string.IsNullOrEmpty(txbCurStreet.Text) ||
                string.IsNullOrEmpty(txbCurTown.Text) ||
                string.IsNullOrEmpty(txbCurProvince.Text))
            {
                MessageBox.Show("Empty string");
                return;
            }
            try
            {
                SetCurrentAddress();
                if(IsValidAddress)
                {
                    cmbPrevious.Text = string.Empty;
                    gpbSetCurAddress.Enabled = false;
                    gpbCurrentAddress.Enabled = true;
                    lblCurrentAddress.Text = $"{fShortStreets.currentAddress} - {fShortStreets.currentAddress.Coordinates}";
                }
            }
            catch (ArgumentException argEx)
            {
                MessageBox.Show(argEx.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Generic error: {ex.Message}");
                return;
            }
        }

        void SetCurrentAddress()
        {
            fShortStreets.currentAddress = new Address(txbCurNumber.Text, txbCurStreet.Text, txbCurTown.Text, txbCurProvince.Text);
            SetCoordinates();
            IsValidAddress = true;
            if (!CoordinatesRangeManager.IsInRange(fShortStreets.coordinatesRange, fShortStreets.currentAddress.Coordinates))
            {
                MessageBox.Show($"Current address coordinates are out of range ({fShortStreets.coordinatesRange})");
                IsValidAddress = false;
                return;
            }
            AddCurrentAddress();
        }
        void SetCoordinates()
        {
            Address a = previousAddresses.SingleOrDefault(x => x.ToString() == fShortStreets.currentAddress.ToString());
            if (a != default)
            {
                fShortStreets.currentAddress.Coordinates = a.Coordinates;
                previousAddresses.Remove(a);
            }
            else
                helper.SetCoordinates(fShortStreets.currentAddress);
        }
        void AddCurrentAddress()
        {
            previousAddresses.Insert(0, fShortStreets.currentAddress);
            RefreshCmbItems();
        }
        void RefreshCmbItems()
        {
            cmbPrevious.Items.Clear();
            cmbPrevious.Items.AddRange(previousAddresses.ToArray());
        }

        private void cmbPrevious_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexChanged();
        }

        private void IndexChanged()
        {
            Address previous = FormsElaboration.GetAddressFromCmb(cmbPrevious, previousAddresses);
            txbCurTown.Text = previous.Town;
            txbCurProvince.Text = previous.Province;
            txbCurStreet.Text = previous.Street;
            txbCurNumber.Text = previous.Number;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            gpbSetCurAddress.Enabled = true;
            gpbCurrentAddress.Enabled = false;
        }

        private void btnSimulatePrevious_Click(object sender, EventArgs e)
        {
            foreach (Address a in Demo.SimulatePreviousAddresses())
                previousAddresses.Add(a);
            RefreshCmbItems();
            btnSimulatePrevious.Enabled = false;
            cmbPrevious.SelectedIndex = 0;
            IndexChanged();
        }

        private void btnRiderSpace_Click(object sender, EventArgs e)
        {
            fShortStreets.ShowFormRiderSpace();
        }

    }
}
