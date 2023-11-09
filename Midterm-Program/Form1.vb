Public Class Form1

    Dim carprice As Integer
    Dim carannual As Integer
    Dim cartotal As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxCarBrand.Items.AddRange({"Honda", "Toyota", "Nissan", "Kia"})

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCompute.Click

        Try

            If ComboBoxCarBrand.SelectedItem = "Honda" And ComboBoxCarModel.SelectedItem = "Jazz" Then

                TextBoxPrice.Text = Format(918000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 11
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Honda" And ComboBoxCarModel.SelectedItem = "City" Then

                TextBoxPrice.Text = Format(1603000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 11
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Toyota" And ComboBoxCarModel.SelectedItem = "Avanza" Then

                TextBoxPrice.Text = Format(1059000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 10
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Toyota" And ComboBoxCarModel.SelectedItem = "Camry" Then

                TextBoxPrice.Text = Format(2457000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 10
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Toyota" And ComboBoxCarModel.SelectedItem = "Altis" Then

                TextBoxPrice.Text = Format(130200000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 10
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Nissan" And ComboBoxCarModel.SelectedItem = "Sentra" Then

                TextBoxPrice.Text = Format(1225500, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 9
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Nissan" And ComboBoxCarModel.SelectedItem = "Patrol" Then

                TextBoxPrice.Text = Format(475800000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 9
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Kia" And ComboBoxCarModel.SelectedItem = "Rio" Then

                TextBoxPrice.Text = Format(920000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 8
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            ElseIf ComboBoxCarBrand.SelectedItem = "Kia" And ComboBoxCarModel.SelectedItem = "Sorento" Then

                TextBoxPrice.Text = Format(2588000, "₱#,###,###,00")
                carprice = TextBoxPrice.Text
                TextBoxAnnualinterest.Text = 8
                carannual = TextBoxAnnualinterest.Text
                carannual = carprice * 0.1
                cartotal = carannual * TextBoxYearstopay.Text
                TextBoxTotalprice.Text = Format(carprice + cartotal, "₱#,###,###,00")
                TextBoxMonthlydues.Text = Format(TextBoxTotalprice.Text / (TextBoxYearstopay.Text * 12), "₱#,###,###,00")

            End If

        Catch ex As Exception

            MessageBox.Show("Mag input ka ng Years to Pay!! -_-")

        End Try

    End Sub

    Private Sub ComboBoxCarBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarBrand.SelectedIndexChanged

        If ComboBoxCarBrand.SelectedItem IsNot Nothing Then

            Dim selectedBrand As String = ComboBoxCarBrand.SelectedItem.ToString()
            ComboBoxCarModel.Items.Clear()

            If selectedBrand = "Honda" Then

                PictureBoxCarbrand.Image = My.Resources.honda_logo
                ComboBoxCarModel.Items.Add("Jazz")
                ComboBoxCarModel.Items.Add("City")

            ElseIf selectedBrand = "Toyota" Then

                PictureBoxCarbrand.Image = My.Resources.toyota_logo
                ComboBoxCarModel.Items.Add("Avanza")
                ComboBoxCarModel.Items.Add("Camry")
                ComboBoxCarModel.Items.Add("Altis")

            ElseIf selectedBrand = "Nissan" Then

                PictureBoxCarbrand.Image = My.Resources.nissan_logo
                ComboBoxCarModel.Items.Add("Sentra")
                ComboBoxCarModel.Items.Add("Patrol")

            ElseIf selectedBrand = "Kia" Then

                PictureBoxCarbrand.Image = My.Resources.kia_logov2
                ComboBoxCarModel.Items.Add("Rio")
                ComboBoxCarModel.Items.Add("Sorento")

            End If

        End If

    End Sub

    Private Sub ComboBoxCarModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCarModel.SelectedIndexChanged

        If ComboBoxCarModel.SelectedItem = "Jazz" Then

            PictureBoxCar.Image = My.Resources.Honda_Jazz

        ElseIf ComboBoxCarModel.SelectedItem = "City" Then

            PictureBoxCar.Image = My.Resources.Honda_city

        ElseIf ComboBoxCarModel.SelectedItem = "Avanza" Then

            PictureBoxCar.Image = My.Resources.toyota_avanza

        ElseIf ComboBoxCarModel.SelectedItem = "Camry" Then

            PictureBoxCar.Image = My.Resources.toyota_camry

        ElseIf ComboBoxCarModel.SelectedItem = "Altis" Then

            PictureBoxCar.Image = My.Resources.toyota_atlis

        ElseIf ComboBoxCarModel.SelectedItem = "Sentra" Then

            PictureBoxCar.Image = My.Resources.nissan_Sentra

        ElseIf ComboBoxCarModel.SelectedItem = "Patrol" Then

            PictureBoxCar.Image = My.Resources.nissan_patrol

        ElseIf ComboBoxCarModel.SelectedItem = "Rio" Then

            PictureBoxCar.Image = My.Resources.kia_rio

        ElseIf ComboBoxCarModel.SelectedItem = "Sorento" Then

            PictureBoxCar.Image = My.Resources.kia_sorento

        End If

    End Sub

    Private Sub TextBoxYearstopay_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBoxYearstopay.MouseClick

        TextBoxYearstopay.Text = Nothing

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click

        TextBoxYearstopay.Text = "Input Year"
        TextBoxPrice.Text = Nothing
        TextBoxAnnualinterest.Text = Nothing
        TextBoxTotalprice.Text = Nothing
        TextBoxMonthlydues.Text = Nothing
        PictureBoxCar.Image = Nothing
        PictureBoxCarbrand.Image = Nothing
        ComboBoxCarBrand.Text = Nothing
        ComboBoxCarModel.Text = Nothing

    End Sub
End Class
