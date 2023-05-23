using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace AutoKeys
{
    public partial class MainWindow : Window
    {
        DispatcherTimer TimerAccion;
        SortedDictionary<string, int> prDict;
        int Id;
        int valormaximo1;
        int valormaximo2;
        int valormaximo3;
        int valormaximo4;
        int valormaximo5;
        int valormaximo6;
        List<TextBox> txts1 = new List<TextBox>();
        List<TextBox> txts2 = new List<TextBox>();
        List<TextBox> txts3 = new List<TextBox>();
        List<TextBox> txts4 = new List<TextBox>();
        List<TextBox> txts5 = new List<TextBox>();
        List<TextBox> txts6 = new List<TextBox>();


        #region Reset Timer
        int A = 0;
        int B = 0;
        int C = 0;
        int D = 0;
        int E = 0;
        int F = 0;
        int G = 0;
        int H = 0;
        int I = 0;
        int J = 0;
        int K = 0;
        int L = 0;
        int M = 0;
        int N = 0;
        int O = 0;
        int P = 0;
        int Q = 0;
        int R = 0;
        int S = 0;
        int T = 0;
        int U = 0;
        int V = 0;
        int W = 0;
        int X = 0;
        int Y = 0;
        int Z = 0;
        int F1 = 0;
        int F2 = 0;
        int F3 = 0;
        int F4 = 0;
        int F5 = 0;
        int F6 = 0;
        int F7 = 0;
        int F8 = 0;
        int F9 = 0;
        int F10 = 0;
        int F11 = 0;
        int F12 = 0;
        int VkNum00 = 0;
        int VkNum01 = 0;
        int VkNum02 = 0;
        int VkNum03 = 0;
        int VkNum04 = 0;
        int VkNum05 = 0;
        int VkNum06 = 0;
        int VkNum07 = 0;
        int VkNum08 = 0;
        int VkNum09 = 0;
        int NumPad00 = 0;
        int NumPad01 = 0;
        int NumPad02 = 0;
        int NumPad03 = 0;
        int NumPad04 = 0;
        int NumPad05 = 0;
        int NumPad06 = 0;
        int NumPad07 = 0;
        int NumPad08 = 0;
        int NumPad09 = 0;
        int Suma = 0;
        int Menos = 0;
        int Divisor = 0;
        int Multiplicar = 0;
        int FlechaUp = 0;
        int FlechaDown = 0;
        int FlechaLeft = 0;
        int FlechaRight = 0;
        int Combo01 = 0;
        int Combo02 = 0;
        int Combo03 = 0;
        int Combo04 = 0;
        int Combo05 = 0;
        int Combo06 = 0;
        int Combo07 = 0;
        int Combo08 = 0;
        int Combo09 = 0;
        int Combo10 = 0;
        int Combo11 = 0;
        int Combo12 = 0;
        int Combo13 = 0;
        int Combo14 = 0;
        int Combo15 = 0;
        int Combo16 = 0;
        int Combo17 = 0;
        int Combo18 = 0;
        int Combo19 = 0;
        int Combo20 = 0;
        int Combo21 = 0;
        int Combo22 = 0;
        int Combo23 = 0;
        int Combo24 = 0;
        int Control = 0;
        int Alt = 0;
        int Enter = 0;
        int Shift = 0;
        int Espacio = 0;
        int Pulsar01 = 0;
        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TimerProcesos()
        {
            TimerAccion = new DispatcherTimer();
            TimerAccion.Interval = TimeSpan.FromSeconds(1);
            TimerAccion.Tick += TimerRefresh_Tick;
            TimerAccion.Start();
        }

        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            //if (ActivarAutoMove1.IsChecked == true)
            //{                
            //    SoltarTecla(lista25);
            //}
            //if (ActivarAutoMove2.IsChecked == true)
            //{
            //    SoltarTecla(lista26);
            //}
            //if (ActivarAutoMove3.IsChecked == true)
            //{
            //    SoltarTecla(lista27);
            //}
            //if (ActivarAutoMove4.IsChecked == true)
            //{
            //    SoltarTecla(lista28);
            //}
            //if (ActivarAutoMove5.IsChecked == true)
            //{
            //    SoltarTecla(lista29);
            //}
            //if (ActivarAutoMove6.IsChecked == true)
            //{
            //    SoltarTecla(lista30);
            //}
            //if (ActivarAutoMove7.IsChecked == true)
            //{
            //    SoltarTecla(lista31);
            //}

                EvaluacionTeclas();
                EvaluacionCombos();         
        }

        private void ActualizacionProcesos()
        {
            prDict = new SortedDictionary<string, int>(Process.GetProcesses().ToDictionary((pr) => string.Format("{0} [{1}]", pr.ProcessName, pr.Id), (pr) => pr.Id), StringComparer.Ordinal);
            this.ltProcesos.ItemsSource = prDict.Keys.ToList();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            ActualizacionProcesos();
        }

        private void ltProcesos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                System.Windows.Controls.ListBox lb = (System.Windows.Controls.ListBox)sender;
                Id = prDict[lb.SelectedItem.ToString()];
            }
            catch
            { }
        }

        private void btnDesactivar_Click(object sender, RoutedEventArgs e)
        {
                TimerAccion.Stop();            
            ResetContador();
            btnComenzar.IsEnabled = true;
            btnDesactivar.IsEnabled = false;
        }

        private void ResetContador()
        {
            A = 0;
            B = 0;
             C = 0;
             D = 0;
             E = 0;
             F = 0;
             G = 0;
             H = 0;
             I = 0;
             J = 0;
             K = 0;
             L = 0;
             M = 0;
             N = 0;
             O = 0;
             P = 0;
             Q = 0;
             R = 0;
             S = 0;
             T = 0;
             U = 0;
             V = 0;
             W = 0;
             X = 0;
             Y = 0;
             Z = 0;
             F1 = 0;
             F2 = 0;
             F3 = 0;
             F4 = 0;
             F5 = 0;
             F6 = 0;
             F7 = 0;
             F8 = 0;
             F9 = 0;
             F10 = 0;
             F11 = 0;
             F12 = 0;
             VkNum00 = 0;
             VkNum01 = 0;
             VkNum02 = 0;
             VkNum03 = 0;
             VkNum04 = 0;
             VkNum05 = 0;
             VkNum06 = 0;
             VkNum07 = 0;
             VkNum08 = 0;
             VkNum09 = 0;
             NumPad00 = 0;
             NumPad01 = 0;
             NumPad02 = 0;
             NumPad03 = 0;
             NumPad04 = 0;
             NumPad05 = 0;
             NumPad06 = 0;
             NumPad07 = 0;
             NumPad08 = 0;
             NumPad09 = 0;
             Suma = 0;
             Menos = 0;
             Divisor = 0;
             Multiplicar = 0;
             FlechaUp = 0;
             FlechaDown = 0;
             FlechaLeft = 0;
             FlechaRight = 0;
             Combo01 = 0;
             Combo02 = 0;
             Combo03 = 0;
             Combo04 = 0;
             Combo05 = 0;
             Combo06 = 0;
             Combo07 = 0;
             Combo08 = 0;
             Combo09 = 0;
             Combo10 = 0;
             Combo11 = 0;
             Combo12 = 0;
             Combo13 = 0;
             Combo14 = 0;
             Combo15 = 0;
             Combo16 = 0;
             Combo17 = 0;
             Combo18 = 0;
             Combo19 = 0;
             Combo20 = 0;
             Combo21 = 0;
             Combo22 = 0;
             Combo23 = 0;
             Combo24 = 0;
            Pulsar01 = 0;
             Control = 0;
             Alt = 0;
             Enter = 0;
             Shift = 0;
             Espacio = 0;
        }

        private void SoloNumeros(System.Windows.Input.TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (ascci >= 48 && ascci <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnComenzar_Click(object sender, RoutedEventArgs e)
        {
            if (ltProcesos.SelectedItem != null)
            {
                TimerProcesos();
                btnComenzar.IsEnabled = false;
                btnDesactivar.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Selecciona un proceso primero, para enviar la acción");
                ActualizacionProcesos();
            }
                  
        }

        private void EvaluacionTeclas()
        {
            if (TimerAccion.IsEnabled == true)
            {
                #region Letras++
                                A++;
                                B++;
                                C++;
                                D++;
                                E++;
                                F++;
                                G++;
                                H++;
                                I++;
                                J++;
                                K++;
                                L++;
                                M++;
                                N++;
                                O++;
                                P++;
                                Q++;
                                R++;
                                S++;
                                T++;
                                U++;
                                V++;
                                W++;
                                X++;
                                Y++;
                Z++;
                #endregion
                #region Funciones++
                F1++;
                F2++;
                F3++;
                F4++;
                F5++;
                F6++;
                F7++;
                F8++;
                F9++;
                F10++;
                F11++;
                F12++;
                #endregion
                #region Teclado Numerico++
                VkNum00++;
                VkNum01++;
                VkNum02++;
                VkNum03++;
                VkNum04++;
                VkNum05++;
                VkNum06++;
                VkNum07++;
                VkNum08++;
                VkNum09++;
                #endregion
                #region Numeros++
                NumPad00++;
                NumPad01++;
                NumPad02++;
                NumPad03++;
                NumPad04++;
                NumPad05++;
                NumPad06++;
                NumPad07++;
                NumPad08++;
                NumPad09++;
                #endregion
                #region Signos++
                Suma++;
                Menos++;
                Divisor++;
                Multiplicar++;
                #endregion
                #region Flechas++
                FlechaDown++;
                FlechaLeft++;
                FlechaRight++;
                FlechaUp++;
                #endregion
                #region Sistema
                 Control++;
                 Alt++;
                 Enter++;
                 Shift++;
                 Espacio++;
                #endregion
            }

            #region Letras

            if (A == Convert.ToInt32(txtLetA.Text))
                        {
                    Teclas.accionTecla(Teclas.LetraA, Id);
                    A = 0;         
                        }
                        if (B == Convert.ToInt32(txtLetB.Text))
                        {
                            Teclas.accionTecla(Teclas.LetraB, Id);
                B = 0;
                        }
                        if (C == Convert.ToInt32(txtLetC.Text))
            {
                            Teclas.accionTecla(Teclas.LetraC, Id);
                C = 0;
                        }
                        if (D == Convert.ToInt32(txtLetD.Text))
            {
                            Teclas.accionTecla(Teclas.LetraD, Id);
                D = 0;
                        }
                        if (E == Convert.ToInt32(txtLetE.Text))
            {
                            Teclas.accionTecla(Teclas.LetraE, Id);
                E = 0;
                        }
                        if (F == Convert.ToInt32(txtLetF.Text))
            {
                            Teclas.accionTecla(Teclas.LetraF, Id);
                F = 0;
                        }
                        if (G == Convert.ToInt32(txtLetG.Text))
            {
                            Teclas.accionTecla(Teclas.LetraG, Id);
                G = 0;
                        }
                        if (H == Convert.ToInt32(txtLetH.Text))
            {
                            Teclas.accionTecla(Teclas.LetraH, Id);
                H = 0;
                        }
                        if (I == Convert.ToInt32(txtLetI.Text))
            {
                            Teclas.accionTecla(Teclas.LetraI, Id);
                I = 0;
                        }
                        if (J == Convert.ToInt32(txtLetJ.Text))
            {
                            Teclas.accionTecla(Teclas.LetraJ, Id);
                J = 0;
                        }
                        if (K == Convert.ToInt32(txtLetK.Text))
            {
                            Teclas.accionTecla(Teclas.LetraK, Id);
                K = 0;
                        }
                        if (L == Convert.ToInt32(txtLetL.Text))
            {
                            Teclas.accionTecla(Teclas.LetraL, Id);
                L = 0;
                        }
                        if (M == Convert.ToInt32(txtLetM.Text))
            {
                            Teclas.accionTecla(Teclas.LetraM, Id);
                M = 0;
                        }
                        if (N == Convert.ToInt32(txtLetN.Text))
            {
                            Teclas.accionTecla(Teclas.LetraN, Id);
                N = 0;
                        }
                        if (O == Convert.ToInt32(txtLetO.Text))
            {
                            Teclas.accionTecla(Teclas.LetraO, Id);
                O = 0;
                        }
                        if (P == Convert.ToInt32(txtLetP.Text))
            {
                            Teclas.accionTecla(Teclas.LetraP, Id);
                P = 0;
                        }
                        if (Q == Convert.ToInt32(txtLetQ.Text))
            {
                            Teclas.accionTecla(Teclas.LetraQ, Id);
                Q = 0;
                        }
                        if (R == Convert.ToInt32(txtLetR.Text))
            {
                            Teclas.accionTecla(Teclas.LetraR, Id);
                R = 0;
                        }
                        if (S == Convert.ToInt32(txtLetS.Text))
            {
                            Teclas.accionTecla(Teclas.LetraS, Id);
                S = 0;
                        }
                        if (T == Convert.ToInt32(txtLetT.Text))
            {
                            Teclas.accionTecla(Teclas.LetraT, Id);
                T = 0;
                        }
                        if (U == Convert.ToInt32(txtLetU.Text))
            {
                            Teclas.accionTecla(Teclas.LetraU, Id);
                U = 0;
                        }
                        if (V == Convert.ToInt32(txtLetV.Text))
            {
                            Teclas.accionTecla(Teclas.LetraV, Id);
                V = 0;
                        }
                        if (W == Convert.ToInt32(txtLetW.Text))
            {
                            Teclas.accionTecla(Teclas.LetraW, Id);
                W = 0;
                        }
                        if (X == Convert.ToInt32(txtLetX.Text))
            {
                            Teclas.accionTecla(Teclas.LetraX, Id);
                X = 0;
                        }
                        if (Y == Convert.ToInt32(txtLetY.Text))
            {
                            Teclas.accionTecla(Teclas.LetraY, Id);
                Y = 0;
                        }
                        if (Z == Convert.ToInt32(txtLetZ.Text))
            {
                            Teclas.accionTecla(Teclas.LetraZ, Id);
                Z = 0;
                        }
                        #endregion
            #region Funciones
            if (F1 == Convert.ToInt32(txtF1.Text))
            {
                Teclas.accionTecla(Teclas.VK_F1, Id);
                F1 = 0;
            }
            if (F2 == Convert.ToInt32(txtF2.Text))
            {
                Teclas.accionTecla(Teclas.VK_F2, Id);
                F2 = 0;
            }
            if (F3 == Convert.ToInt32(txtF3.Text))
            {
                Teclas.accionTecla(Teclas.VK_F3, Id);
                F3 = 0;
            }
            if (F4 == Convert.ToInt32(txtF4.Text))
            {
                Teclas.accionTecla(Teclas.VK_F4, Id);
                F4 = 0;
            }
            if (F5 == Convert.ToInt32(txtF5.Text))
            {
                Teclas.accionTecla(Teclas.VK_F5, Id);
                F5 = 0;
            }
            if (F6 == Convert.ToInt32(txtF6.Text))
            {
                Teclas.accionTecla(Teclas.VK_F6, Id);
                F6 = 0;
            }
            if (F7 == Convert.ToInt32(txtF7.Text))
            {
                Teclas.accionTecla(Teclas.VK_F7, Id);
                F7 = 0;
            }
            if (F8 == Convert.ToInt32(txtF8.Text))
            {
                Teclas.accionTecla(Teclas.VK_F8, Id);
                F8 = 0;
            }
            if (F9 == Convert.ToInt32(txtF9.Text))
            {
                Teclas.accionTecla(Teclas.VK_F9, Id);
                F9 = 0;
            }
            if (F10 == Convert.ToInt32(txtF10.Text))
            {
                Teclas.accionTecla(Teclas.VK_F10, Id);
                F10 = 0;
            }
            if (F11 == Convert.ToInt32(txtF11.Text))
            {
                Teclas.accionTecla(Teclas.VK_F11, Id);
                F11 = 0;
            }
            if (F12 == Convert.ToInt32(txtF12.Text))
            {
                Teclas.accionTecla(Teclas.VK_F12, Id);
                F12 = 0;
            }
            #endregion
            #region Teclado Numerico
            if (VkNum00 == Convert.ToInt32(txtTN0.Text))
            {
                Teclas.accionTecla(Teclas.VkNum00, Id);
                VkNum00 = 0;
            }
            if (VkNum01 == Convert.ToInt32(txtTN01.Text))
            {
                Teclas.accionTecla(Teclas.VkNum01, Id);
                VkNum01 = 0;
            }
            if (VkNum02 == Convert.ToInt32(txtTN02.Text))
            {
                Teclas.accionTecla(Teclas.VkNum02, Id);
                VkNum02 = 0;
            }
            if (VkNum03 == Convert.ToInt32(txtTN03.Text))
            {
                Teclas.accionTecla(Teclas.VkNum03, Id);
                VkNum03 = 0;
            }
            if (VkNum04 == Convert.ToInt32(txtTN04.Text))
            {
                Teclas.accionTecla(Teclas.VkNum04, Id);
                VkNum04 = 0;
            }
            if (VkNum05 == Convert.ToInt32(txtTN05.Text))
            {
                Teclas.accionTecla(Teclas.VkNum05, Id);
                VkNum05 = 0;
            }
            if (VkNum06 == Convert.ToInt32(txtTN06.Text))
            {
                Teclas.accionTecla(Teclas.VkNum06, Id);
                VkNum06 = 0;
            }
            if (VkNum07 == Convert.ToInt32(txtTN07.Text))
            {
                Teclas.accionTecla(Teclas.VkNum07, Id);
                VkNum07 = 0;
            }
            if (VkNum08 == Convert.ToInt32(txtTN08.Text))
            {
                Teclas.accionTecla(Teclas.VkNum08, Id);
                VkNum08 = 0;
            }
            if (VkNum09 == Convert.ToInt32(txtTN09.Text))
            {
                Teclas.accionTecla(Teclas.VkNum09, Id);
                VkNum09 = 0;
            }
            #endregion
            #region Numeros
            if (NumPad00 == Convert.ToInt32(txtNum0.Text))
            {
                Teclas.accionTecla(Teclas.NumPad00, Id);
                NumPad00 = 0;
            }
            if (NumPad01 == Convert.ToInt32(txtNum1.Text))
            {
                Teclas.accionTecla(Teclas.NumPad01, Id);
                NumPad01 = 0;
            }
            if (NumPad02 == Convert.ToInt32(txtNum2.Text))
            {
                Teclas.accionTecla(Teclas.NumPad02, Id);
                NumPad02 = 0;
            }
            if (NumPad03 == Convert.ToInt32(txtNum3.Text))
            {
                Teclas.accionTecla(Teclas.NumPad03, Id);
                NumPad03 = 0;
            }
            if (NumPad04 == Convert.ToInt32(txtNum4.Text))
            {
                Teclas.accionTecla(Teclas.NumPad04, Id);
                NumPad04 = 0;
            }
            if (NumPad05 == Convert.ToInt32(txtNum5.Text))
            {
                Teclas.accionTecla(Teclas.NumPad05, Id);
                NumPad05 = 0;
            }
            if (NumPad06 == Convert.ToInt32(txtNum6.Text))
            {
                Teclas.accionTecla(Teclas.NumPad06, Id);
                NumPad06 = 0;
            }
            if (NumPad07 == Convert.ToInt32(txtNum7.Text))
            {
                Teclas.accionTecla(Teclas.NumPad07, Id);
                NumPad07 = 0;
            }
            if (NumPad08 == Convert.ToInt32(txtNum8.Text))
            {
                Teclas.accionTecla(Teclas.NumPad08, Id);
                NumPad08 = 0;
            }
            if (NumPad09 == Convert.ToInt32(txtNum9.Text))
            {
                Teclas.accionTecla(Teclas.NumPad09, Id);
                NumPad09 = 0;
            }
            #endregion
            #region Signos
            if (Suma == Convert.ToInt32(txtMas.Text))
            {
                Teclas.accionTecla(Teclas.Suma, Id);
                Suma = 0;
            }
            if (Menos == Convert.ToInt32(txtMenos.Text))
            {
                Teclas.accionTecla(Teclas.Menos, Id);
                Menos = 0;
            }
            if (Divisor == Convert.ToInt32(txtDivisor.Text))
            {
                Teclas.accionTecla(Teclas.Divisor, Id);
                Divisor = 0;
            }
            if (Multiplicar == Convert.ToInt32(txtAsterisco.Text))
            {
                Teclas.accionTecla(Teclas.Multiplicar, Id);
                Multiplicar = 0;
            }
            #endregion
            #region Flechas
            if (FlechaUp == Convert.ToInt32(txtFleU.Text))
            {
                Teclas.accionTecla(Teclas.FlechaUp, Id);
                FlechaUp = 0;
            }
            if (FlechaDown == Convert.ToInt32(txtFleD.Text))
            {
                Teclas.accionTecla(Teclas.FlechaDown, Id);
                FlechaDown = 0;
            }
            if (FlechaLeft == Convert.ToInt32(txtFleL.Text))
            {
                Teclas.accionTecla(Teclas.FlechaLeft, Id);
                FlechaLeft = 0;
            }
            if (FlechaRight == Convert.ToInt32(txtFleR.Text))
            {
                Teclas.accionTecla(Teclas.FlechaRight, Id);
                FlechaRight = 0;
            }
            #endregion
            #region Sistema
            if (Control == Convert.ToInt32(txtControl.Text))
            {
                Teclas.accionTecla(Teclas.VK_CONTROL, Id);
                Control = 0;
            }
            if (Alt == Convert.ToInt32(txtAlt.Text))
            {
                Teclas.accionTecla(Teclas.VK_ALT, Id);
                Alt = 0;
            }
            if (Espacio == Convert.ToInt32(txtEspacio.Text))
            {
                Teclas.accionTecla(Teclas.VK_SPACE, Id);
                Espacio = 0;
            }
            if (Shift == Convert.ToInt32(txtShift.Text))
            {
                Teclas.accionTecla(Teclas.VK_SHIFT, Id);
                Shift = 0;
            }
            if (Enter == Convert.ToInt32(txtEnter.Text))
            {
                Teclas.accionTecla(Teclas.VK_ENTER, Id);
                Enter = 0;
            }
            #endregion
        }

        #region TextBox
        private void txtF1_PreviewTextInput_1(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF2_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF3_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF4_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF5_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF6_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF7_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF8_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF9_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF10_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF11_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtF12_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFleU_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFleD_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFleL_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFleR_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtMenos_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtMas_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtDivisor_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum0_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum1_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum2_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum3_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum4_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum5_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum6_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum7_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum8_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNum9_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN0_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN01_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN02_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN03_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN04_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN05_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN06_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN07_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN08_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTN09_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetA_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetB_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetC_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetD_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetE_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetF_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetG_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetH_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetI_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetJ_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetK_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetL_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetM_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetN_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetO_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetP_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetQ_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetR_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetS_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetT_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetU_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetV_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetW_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetX_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetY_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLetZ_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtAsterisco_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtControl_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtAlt_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtEspacio_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtEnter_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtShift_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            SoloNumeros(e);
        }
        #endregion

        private void CargaComboBox(ComboBox ComboBox)
        {
            ComboBox.Items.Add("A");
            ComboBox.Items.Add("B");
            ComboBox.Items.Add("C");
            ComboBox.Items.Add("D");
            ComboBox.Items.Add("E");
            ComboBox.Items.Add("F");
            ComboBox.Items.Add("G");
            ComboBox.Items.Add("H");
            ComboBox.Items.Add("I");
            ComboBox.Items.Add("J");
            ComboBox.Items.Add("K");
            ComboBox.Items.Add("L");
            ComboBox.Items.Add("M");
            ComboBox.Items.Add("N");
            ComboBox.Items.Add("O");
            ComboBox.Items.Add("P");
            ComboBox.Items.Add("Q");
            ComboBox.Items.Add("R");
            ComboBox.Items.Add("S");
            ComboBox.Items.Add("T");
            ComboBox.Items.Add("U");
            ComboBox.Items.Add("V");
            ComboBox.Items.Add("W");
            ComboBox.Items.Add("X");
            ComboBox.Items.Add("Y");
            ComboBox.Items.Add("Z");
            ComboBox.Items.Add("NumPad00");
            ComboBox.Items.Add("NumPad01");
            ComboBox.Items.Add("NumPad02");
            ComboBox.Items.Add("NumPad03");
            ComboBox.Items.Add("NumPad04");
            ComboBox.Items.Add("NumPad05");
            ComboBox.Items.Add("NumPad06");
            ComboBox.Items.Add("NumPad07");
            ComboBox.Items.Add("NumPad08");
            ComboBox.Items.Add("NumPad09");
            ComboBox.Items.Add("TN00");
            ComboBox.Items.Add("TN01");
            ComboBox.Items.Add("TN02");
            ComboBox.Items.Add("TN03");
            ComboBox.Items.Add("TN04");
            ComboBox.Items.Add("TN05");
            ComboBox.Items.Add("TN06");
            ComboBox.Items.Add("TN07");
            ComboBox.Items.Add("TN08");
            ComboBox.Items.Add("TN09");
            ComboBox.Items.Add("/");
            ComboBox.Items.Add("*");
            ComboBox.Items.Add("-");
            ComboBox.Items.Add("+");
            ComboBox.Items.Add("F1");
            ComboBox.Items.Add("F2");
            ComboBox.Items.Add("F3");
            ComboBox.Items.Add("F4");
            ComboBox.Items.Add("F5");
            ComboBox.Items.Add("F6");
            ComboBox.Items.Add("F7");
            ComboBox.Items.Add("F8");
            ComboBox.Items.Add("F9");
            ComboBox.Items.Add("F10");
            ComboBox.Items.Add("F11");
            ComboBox.Items.Add("F12");
            ComboBox.Items.Add("Flecha Izquierda");
            ComboBox.Items.Add("Flecha Derecha");
            ComboBox.Items.Add("Flecha Arriba");
            ComboBox.Items.Add("Flecha Abajo");
            ComboBox.Items.Add("Control");
            ComboBox.Items.Add("Alt");
            ComboBox.Items.Add("Shift");
            ComboBox.Items.Add("Enter");
            ComboBox.Items.Add("Espacio");
        }

        private void ValorMayor()
        {
            txts1.AddRange(new[] { txtSecuencia1, txtSecuencia2, txtSecuencia3, txtSecuencia4 });
            txts2.AddRange(new[] { txtSecuencia5, txtSecuencia6, txtSecuencia7, txtSecuencia8 });
            txts3.AddRange(new[] { txtSecuencia9, txtSecuencia10, txtSecuencia11, txtSecuencia12 });
            txts4.AddRange(new[] { txtSecuencia13, txtSecuencia14, txtSecuencia15, txtSecuencia16 });
            txts5.AddRange(new[] { txtSecuencia17, txtSecuencia18, txtSecuencia19, txtSecuencia20 });
            txts6.AddRange(new[] { txtSecuencia21, txtSecuencia22, txtSecuencia23, txtSecuencia24 });
            valormaximo1 = txts1.Max(x => Convert.ToInt32(x.Text));
            valormaximo2 = txts2.Max(x => Convert.ToInt32(x.Text));
            valormaximo3 = txts3.Max(x => Convert.ToInt32(x.Text));
            valormaximo4 = txts4.Max(x => Convert.ToInt32(x.Text));
            valormaximo5 = txts5.Max(x => Convert.ToInt32(x.Text));
            valormaximo6 = txts6.Max(x => Convert.ToInt32(x.Text));
        }

        private void EvaluacionCombos()
        {
            ValorMayor();
            if (TimerAccion.IsEnabled == true)
            {
                #region Combos
                Combo01++;
                Combo02++;
                Combo03++;
                Combo04++;
                Combo05++;
                Combo06++;
                Combo07++;
                Combo08++;
                Combo09++;
                Combo10++;
                Combo11++;
                Combo12++;
                Combo13++;
                Combo14++;
                Combo15++;
                Combo16++;
                Combo17++;
                Combo18++;
                Combo19++;
                Combo20++;
                Combo21++;
                Combo22++;
                Combo23++;
                Combo24++;
                #endregion
            }
            if (Secuencia1.IsChecked == true)
            {
                if (Combo01 == Convert.ToInt32(txtSecuencia1.Text))
                {
                    AccionCombo(Combo01, lista1);                    
                }
                if (Combo02 == Convert.ToInt32(txtSecuencia2.Text))
                {
                    AccionCombo(Combo02, lista2);                   
                }
                if (Combo03 == Convert.ToInt32(txtSecuencia3.Text))
                {
                    AccionCombo(Combo03, lista3);                
                }
                if (Combo04 == Convert.ToInt32(txtSecuencia4.Text))
                {
                    AccionCombo(Combo04, lista4);                    
                }
                if (Combo01 == valormaximo1)
                {
                    Combo01 = 0;
                    Combo02 = 0;
                    Combo03 = 0;
                    Combo04 = 0;
                }
            }
            if (Secuencia2.IsChecked == true)
            {
                if (Combo05 == Convert.ToInt32(txtSecuencia5.Text))
                {
                    AccionCombo(Combo05, lista5);
                }
                if (Combo06 == Convert.ToInt32(txtSecuencia6.Text))
                {
                    AccionCombo(Combo06, lista6);
                }
                if (Combo07 == Convert.ToInt32(txtSecuencia7.Text))
                {
                    AccionCombo(Combo07, lista7);
                }
                if (Combo08 == Convert.ToInt32(txtSecuencia8.Text))
                {
                    AccionCombo(Combo08, lista8);
                }
                if (Combo05 == valormaximo2)
                {
                    Combo05 = 0;
                    Combo06 = 0;
                    Combo07 = 0;
                    Combo08 = 0;
                }
            }
            if (Secuencia3.IsChecked == true)
            {
                if (Combo09 == Convert.ToInt32(txtSecuencia9.Text))
                {
                    AccionCombo(Combo09, lista9);
                }
                if (Combo10 == Convert.ToInt32(txtSecuencia10.Text))
                {
                    AccionCombo(Combo10, lista10);
                }
                if (Combo11 == Convert.ToInt32(txtSecuencia11.Text))
                {
                    AccionCombo(Combo11, lista11);
                }
                if (Combo12 == Convert.ToInt32(txtSecuencia12.Text))
                {
                    AccionCombo(Combo12, lista12);
                }
                if (Combo09 == valormaximo3)
                {
                    Combo09 = 0;
                    Combo10 = 0;
                    Combo11 = 0;
                    Combo12 = 0;
                }
            }
            if (Secuencia4.IsChecked == true)
            {
                if (Combo13 == Convert.ToInt32(txtSecuencia13.Text))
                {
                    AccionCombo(Combo13, lista13);
                }
                if (Combo14 == Convert.ToInt32(txtSecuencia14.Text))
                {
                    AccionCombo(Combo14, lista14);
                }
                if (Combo15 == Convert.ToInt32(txtSecuencia15.Text))
                {
                    AccionCombo(Combo15, lista15);
                }
                if (Combo16 == Convert.ToInt32(txtSecuencia16.Text))
                {
                    AccionCombo(Combo16, lista16);
                }
                if (Combo13 == valormaximo4)
                {
                    Combo13 = 0;
                    Combo14 = 0;
                    Combo15 = 0;
                    Combo16 = 0;
                }
            }
            if (Secuencia5.IsChecked == true)
            {
                if (Combo17 == Convert.ToInt32(txtSecuencia17.Text))
                {
                    AccionCombo(Combo17, lista17);
                }
                if (Combo18 == Convert.ToInt32(txtSecuencia18.Text))
                {
                    AccionCombo(Combo18, lista18);
                }
                if (Combo19 == Convert.ToInt32(txtSecuencia19.Text))
                {
                    AccionCombo(Combo19, lista19);
                }
                if (Combo20 == Convert.ToInt32(txtSecuencia20.Text))
                {
                    AccionCombo(Combo20, lista20);
                }
                if (Combo17 == valormaximo5)
                {
                    Combo17 = 0;
                    Combo18 = 0;
                    Combo19 = 0;
                    Combo20 = 0;
                }
            }
            if (Secuencia6.IsChecked == true)
            {
                if (Combo21 == Convert.ToInt32(txtSecuencia21.Text))
                {
                    AccionCombo(Combo21, lista21);
                }
                if (Combo22 == Convert.ToInt32(txtSecuencia22.Text))
                {
                    AccionCombo(Combo22, lista22);
                }
                if (Combo23 == Convert.ToInt32(txtSecuencia23.Text))
                {
                    AccionCombo(Combo23, lista23);
                }
                if (Combo24 == Convert.ToInt32(txtSecuencia24.Text))
                {
                    AccionCombo(Combo24, lista24);
                }
                if (Combo21 == valormaximo6)
                {
                    Combo21 = 0;
                    Combo22 = 0;
                    Combo23 = 0;
                    Combo24 = 0;
                }
            }            
        }

        private void AccionCombo(int ResetTimer, ComboBox Combo)
        {
            if (Combo.SelectedItem.Equals("A"))
            {
                Teclas.accionTecla(Teclas.LetraA, Id);                    
            }
            if (Combo.SelectedItem.Equals("B"))
            {
                Teclas.accionTecla(Teclas.LetraB, Id);
            }
            if (Combo.SelectedItem.Equals("C"))
            {
                Teclas.accionTecla(Teclas.LetraC, Id);
            }
            if (Combo.SelectedItem.Equals("D"))
            {
                Teclas.accionTecla(Teclas.LetraD, Id);
            }
            if (Combo.SelectedItem.Equals("E"))
            {
                Teclas.accionTecla(Teclas.LetraE, Id);
            }
            if (Combo.SelectedItem.Equals("F"))
            {
                Teclas.accionTecla(Teclas.LetraF, Id);
            }
            if (Combo.SelectedItem.Equals("G"))
            {
                Teclas.accionTecla(Teclas.LetraG, Id);
            }
            if (Combo.SelectedItem.Equals("H"))
            {
                Teclas.accionTecla(Teclas.LetraH, Id);
            }
            if (Combo.SelectedItem.Equals("I"))
            {
                Teclas.accionTecla(Teclas.LetraI, Id);
            }
            if (Combo.SelectedItem.Equals("J"))
            {
                Teclas.accionTecla(Teclas.LetraJ, Id);
            }
            if (Combo.SelectedItem.Equals("K"))
            {
                Teclas.accionTecla(Teclas.LetraK, Id);
            }
            if (Combo.SelectedItem.Equals("L"))
            {
                Teclas.accionTecla(Teclas.LetraL, Id);
            }
            if (Combo.SelectedItem.Equals("M"))
            {
                Teclas.accionTecla(Teclas.LetraM, Id);
            }
            if (Combo.SelectedItem.Equals("N"))
            {
                Teclas.accionTecla(Teclas.LetraN, Id);
            }
            if (Combo.SelectedItem.Equals("O"))
            {
                Teclas.accionTecla(Teclas.LetraO, Id);
            }
            if (Combo.SelectedItem.Equals("P"))
            {
                Teclas.accionTecla(Teclas.LetraP, Id);
            }
            if (Combo.SelectedItem.Equals("Q"))
            {
                Teclas.accionTecla(Teclas.LetraQ, Id);
            }
            if (Combo.SelectedItem.Equals("R"))
            {
                Teclas.accionTecla(Teclas.LetraR, Id);
            }
            if (Combo.SelectedItem.Equals("S"))
            {
                Teclas.accionTecla(Teclas.LetraS, Id);
            }
            if (Combo.SelectedItem.Equals("T"))
            {
                Teclas.accionTecla(Teclas.LetraT, Id);
            }
            if (Combo.SelectedItem.Equals("U"))
            {
                Teclas.accionTecla(Teclas.LetraU, Id);
            }
            if (Combo.SelectedItem.Equals("V"))
            {
                Teclas.accionTecla(Teclas.LetraV, Id);
            }
            if (Combo.SelectedItem.Equals("W"))
            {
                Teclas.accionTecla(Teclas.LetraW, Id);
            }
            if (Combo.SelectedItem.Equals("X"))
            {
                Teclas.accionTecla(Teclas.LetraX, Id);
            }
            if (Combo.SelectedItem.Equals("Y"))
            {
                Teclas.accionTecla(Teclas.LetraY, Id);
            }
            if (Combo.SelectedItem.Equals("Z"))
            {
                Teclas.accionTecla(Teclas.LetraZ, Id);
            }
            if (Combo.SelectedItem.Equals("F1"))
            {
                Teclas.accionTecla(Teclas.VK_F1, Id);
            }
            if (Combo.SelectedItem.Equals("F2"))
            {
                Teclas.accionTecla(Teclas.VK_F2, Id);
            }
            if (Combo.SelectedItem.Equals("F3"))
            {
                Teclas.accionTecla(Teclas.VK_F3, Id);
            }
            if (Combo.SelectedItem.Equals("F4"))
            {
                Teclas.accionTecla(Teclas.VK_F4, Id);
            }
            if (Combo.SelectedItem.Equals("F5"))
            {
                Teclas.accionTecla(Teclas.VK_F5, Id);
            }
            if (Combo.SelectedItem.Equals("F6"))
            {
                Teclas.accionTecla(Teclas.VK_F6, Id);
            }
            if (Combo.SelectedItem.Equals("F7"))
            {
                Teclas.accionTecla(Teclas.VK_F7, Id);
            }
            if (Combo.SelectedItem.Equals("F8"))
            {
                Teclas.accionTecla(Teclas.VK_F8, Id);
            }
            if (Combo.SelectedItem.Equals("F9"))
            {
                Teclas.accionTecla(Teclas.VK_F9, Id);
            }
            if (Combo.SelectedItem.Equals("F10"))
            {
                Teclas.accionTecla(Teclas.VK_F10, Id);
            }
            if (Combo.SelectedItem.Equals("F11"))
            {
                Teclas.accionTecla(Teclas.VK_F11, Id);
            }
            if (Combo.SelectedItem.Equals("F12"))
            {
                Teclas.accionTecla(Teclas.VK_F12, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad00"))
            {
                Teclas.accionTecla(Teclas.NumPad00, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad01"))
            {
                Teclas.accionTecla(Teclas.NumPad01, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad02"))
            {
                Teclas.accionTecla(Teclas.NumPad02, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad03"))
            {
                Teclas.accionTecla(Teclas.NumPad03, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad04"))
            {
                Teclas.accionTecla(Teclas.NumPad04, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad05"))
            {
                Teclas.accionTecla(Teclas.NumPad05, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad06"))
            {
                Teclas.accionTecla(Teclas.NumPad06, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad07"))
            {
                Teclas.accionTecla(Teclas.NumPad07, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad08"))
            {
                Teclas.accionTecla(Teclas.NumPad08, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad09"))
            {
                Teclas.accionTecla(Teclas.NumPad09, Id);
            }
            if (Combo.SelectedItem.Equals("TN00"))
            {
                Teclas.accionTecla(Teclas.VkNum00, Id);
            }
            if (Combo.SelectedItem.Equals("TN01"))
            {
                Teclas.accionTecla(Teclas.VkNum01, Id);
            }
            if (Combo.SelectedItem.Equals("TN02"))
            {
                Teclas.accionTecla(Teclas.VkNum02, Id);
            }
            if (Combo.SelectedItem.Equals("TN03"))
            {
                Teclas.accionTecla(Teclas.VkNum03, Id);
            }
            if (Combo.SelectedItem.Equals("TN04"))
            {
                Teclas.accionTecla(Teclas.VkNum04, Id);
            }
            if (Combo.SelectedItem.Equals("TN05"))
            {
                Teclas.accionTecla(Teclas.VkNum05, Id);
            }
            if (Combo.SelectedItem.Equals("TN06"))
            {
                Teclas.accionTecla(Teclas.VkNum06, Id);
            }
            if (Combo.SelectedItem.Equals("TN07"))
            {
                Teclas.accionTecla(Teclas.VkNum07, Id);
            }
            if (Combo.SelectedItem.Equals("TN08"))
            {
                Teclas.accionTecla(Teclas.VkNum08, Id);
            }
            if (Combo.SelectedItem.Equals("TN09"))
            {
                Teclas.accionTecla(Teclas.VkNum09, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Arriba"))
            {
                Teclas.accionTecla(Teclas.FlechaUp, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Abajo"))
            {
                Teclas.accionTecla(Teclas.FlechaDown, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Izquierda"))
            {
                Teclas.accionTecla(Teclas.FlechaLeft, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Derecha"))
            {
                Teclas.accionTecla(Teclas.FlechaRight, Id);
            }
            if (Combo.SelectedItem.Equals("/"))
            {
                Teclas.accionTecla(Teclas.Divisor, Id);
            }
            if (Combo.SelectedItem.Equals("*"))
            {
                Teclas.accionTecla(Teclas.Multiplicar, Id);
            }
            if (Combo.SelectedItem.Equals("-"))
            {
                Teclas.accionTecla(Teclas.Menos, Id);
            }
            if (Combo.SelectedItem.Equals("+"))
            {
                Teclas.accionTecla(Teclas.Suma, Id);
            }
            if (Combo.SelectedItem.Equals("Control"))
            {
                Teclas.accionTecla(Teclas.VK_CONTROL, Id);
            }
            if (Combo.SelectedItem.Equals("Alt"))
            {
                Teclas.accionTecla(Teclas.VK_ALT, Id);
            }
            if (Combo.SelectedItem.Equals("Shift"))
            {
                Teclas.accionTecla(Teclas.VK_SHIFT, Id);
            }
            if (Combo.SelectedItem.Equals("Espacio"))
            {
                Teclas.accionTecla(Teclas.VK_SPACE, Id);
            }
            if (Combo.SelectedItem.Equals("Enter"))
            {
                Teclas.accionTecla(Teclas.VK_ENTER, Id);
            }
        
        }

        private void SoltarTecla(ComboBox Combo)
        {
            Pulsar01++;

            if (Pulsar01 == 1)
            {
                if (Combo.SelectedItem.Equals("A"))
                {
                    Teclas.soltarTecla(Teclas.LetraA, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            
                if (Combo.SelectedItem.Equals("B"))
            {
                    Teclas.soltarTecla(Teclas.LetraB, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("C"))
            {
                    Teclas.soltarTecla(Teclas.LetraC, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("D"))
            {
                    Teclas.soltarTecla(Teclas.LetraD, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("E"))
            {
                    Teclas.soltarTecla(Teclas.LetraE, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F"))
            {
                    Teclas.soltarTecla(Teclas.LetraF, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("G"))
            {
                    Teclas.soltarTecla(Teclas.LetraG, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("H"))
            {
                    Teclas.soltarTecla(Teclas.LetraH, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("I"))
            {
                    Teclas.soltarTecla(Teclas.LetraI, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("J"))
            {
                    Teclas.soltarTecla(Teclas.LetraJ, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("K"))
            {
                    Teclas.soltarTecla(Teclas.LetraK, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("L"))
            {
                    Teclas.soltarTecla(Teclas.LetraL, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("M"))
            {
                    Teclas.soltarTecla(Teclas.LetraM, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("N"))
            {
                    Teclas.soltarTecla(Teclas.LetraN, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("O"))
            {
                    Teclas.soltarTecla(Teclas.LetraO, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("P"))
            {
                    Teclas.soltarTecla(Teclas.LetraP, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Q"))
            {
                    Teclas.soltarTecla(Teclas.LetraQ, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("R"))
            {
                    Teclas.soltarTecla(Teclas.LetraR, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("S"))
            {
                    Teclas.soltarTecla(Teclas.LetraS, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("T"))
            {
                    Teclas.soltarTecla(Teclas.LetraT, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("U"))
            {
                    Teclas.soltarTecla(Teclas.LetraU, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("V"))
            {
                    Teclas.soltarTecla(Teclas.LetraV, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("W"))
            {
                    Teclas.soltarTecla(Teclas.LetraW, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("X"))
            {
                    Teclas.soltarTecla(Teclas.LetraX, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Y"))
            {
                    Teclas.soltarTecla(Teclas.LetraY, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Z"))
            {
                    Teclas.soltarTecla(Teclas.LetraZ, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F1"))
            {
                    Teclas.soltarTecla(Teclas.VK_F1, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F2"))
            {
                    Teclas.soltarTecla(Teclas.VK_F2, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F3"))
            {
                    Teclas.soltarTecla(Teclas.VK_F3, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F4"))
            {
                    Teclas.soltarTecla(Teclas.VK_F4, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F5"))
            {
                    Teclas.soltarTecla(Teclas.VK_F5, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F6"))
            {
                    Teclas.soltarTecla(Teclas.VK_F6, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F7"))
            {
                    Teclas.soltarTecla(Teclas.VK_F7, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F8"))
            {
                    Teclas.soltarTecla(Teclas.VK_F8, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F9"))
            {
                    Teclas.soltarTecla(Teclas.VK_F9, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F10"))
            {
                    Teclas.soltarTecla(Teclas.VK_F10, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F11"))
            {
                    Teclas.soltarTecla(Teclas.VK_F11, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("F12"))
            {
                    Teclas.soltarTecla(Teclas.VK_F12, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad00"))
            {
                    Teclas.soltarTecla(Teclas.NumPad00, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad01"))
            {
                    Teclas.soltarTecla(Teclas.NumPad01, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad02"))
            {
                    Teclas.soltarTecla(Teclas.NumPad02, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad03"))
            {
                    Teclas.soltarTecla(Teclas.NumPad03, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad04"))
            {
                    Teclas.soltarTecla(Teclas.NumPad04, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad05"))
            {
                    Teclas.soltarTecla(Teclas.NumPad05, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad06"))
            {
                    Teclas.soltarTecla(Teclas.NumPad06, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad07"))
            {
                    Teclas.soltarTecla(Teclas.NumPad07, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad08"))
            {
                    Teclas.soltarTecla(Teclas.NumPad08, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("NumPad09"))
            {
                    Teclas.soltarTecla(Teclas.NumPad09, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN00"))
            {
                    Teclas.soltarTecla(Teclas.VkNum00, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN01"))
            {
                    Teclas.soltarTecla(Teclas.VkNum01, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN02"))
            {
                    Teclas.soltarTecla(Teclas.VkNum02, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN03"))
            {
                    Teclas.soltarTecla(Teclas.VkNum03, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN04"))
            {
                    Teclas.soltarTecla(Teclas.VkNum04, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN05"))
            {
                    Teclas.soltarTecla(Teclas.VkNum05, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN06"))
            {
                    Teclas.soltarTecla(Teclas.VkNum06, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN07"))
            {
                    Teclas.soltarTecla(Teclas.VkNum07, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN08"))
            {
                    Teclas.soltarTecla(Teclas.VkNum08, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("TN09"))
            {
                    Teclas.soltarTecla(Teclas.VkNum09, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Flecha Arriba"))
            {
                    Teclas.soltarTecla(Teclas.FlechaUp, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Flecha Abajo"))
            {
                    Teclas.soltarTecla(Teclas.FlechaDown, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Flecha Izquierda"))
            {
                    Teclas.soltarTecla(Teclas.FlechaLeft, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Flecha Derecha"))
            {
                    Teclas.soltarTecla(Teclas.FlechaRight, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("/"))
            {
                    Teclas.soltarTecla(Teclas.Divisor, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("*"))
            {
                    Teclas.soltarTecla(Teclas.Multiplicar, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("-"))
            {
                    Teclas.soltarTecla(Teclas.Menos, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("+"))
            {
                    Teclas.soltarTecla(Teclas.Suma, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Control"))
            {
                    Teclas.soltarTecla(Teclas.VK_CONTROL, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Alt"))
            {
                    Teclas.soltarTecla(Teclas.VK_ALT, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Shift"))
            {
                    Teclas.soltarTecla(Teclas.VK_SHIFT, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Espacio"))
            {
                    Teclas.soltarTecla(Teclas.VK_SPACE, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            if (Combo.SelectedItem.Equals("Enter"))
            {
                    Teclas.soltarTecla(Teclas.VK_ENTER, Id);
                    TimerAccion.Stop();
                    Pulsar01 = 0;
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            btnDesactivar.IsEnabled = false;
            CargaComboBox(lista1);
            CargaComboBox(lista2);
            CargaComboBox(lista3);
            CargaComboBox(lista4);
            CargaComboBox(lista5);
            CargaComboBox(lista6);
            CargaComboBox(lista7);
            CargaComboBox(lista8);
            CargaComboBox(lista9);
            CargaComboBox(lista10);
            CargaComboBox(lista11);
            CargaComboBox(lista12);
            CargaComboBox(lista13);
            CargaComboBox(lista14);
            CargaComboBox(lista15);
            CargaComboBox(lista16);
            CargaComboBox(lista17);
            CargaComboBox(lista18);
            CargaComboBox(lista19);
            CargaComboBox(lista20);
            CargaComboBox(lista21);
            CargaComboBox(lista22);
            CargaComboBox(lista23);
            CargaComboBox(lista24);
            CargaComboBox(lista25);
            CargaComboBox(lista26);
            CargaComboBox(lista27);
            CargaComboBox(lista28);
            CargaComboBox(lista29);
            CargaComboBox(lista30);
            CargaComboBox(lista31);
            lista1.SelectedIndex = 0;
            lista2.SelectedIndex = 0;
            lista3.SelectedIndex = 0;
            lista4.SelectedIndex = 0;
            lista5.SelectedIndex = 0;
            lista6.SelectedIndex = 0;
            lista7.SelectedIndex = 0;
            lista8.SelectedIndex = 0;
            lista9.SelectedIndex = 0;
            lista10.SelectedIndex = 0;
            lista11.SelectedIndex = 0;
            lista12.SelectedIndex = 0;
            lista13.SelectedIndex = 0;
            lista14.SelectedIndex = 0;
            lista15.SelectedIndex = 0;
            lista16.SelectedIndex = 0;
            lista17.SelectedIndex = 0;
            lista18.SelectedIndex = 0;
            lista19.SelectedIndex = 0;
            lista20.SelectedIndex = 0;
            lista21.SelectedIndex = 0;
            lista22.SelectedIndex = 0;
            lista23.SelectedIndex = 0;
            lista24.SelectedIndex = 0;
            lista25.SelectedIndex = 0;
            lista26.SelectedIndex = 0;
            lista27.SelectedIndex = 0;
            lista28.SelectedIndex = 0;
            lista29.SelectedIndex = 0;
            lista30.SelectedIndex = 0;
            lista31.SelectedIndex = 0;
        }

        private void GuardarConfig()
        {
            List<string> Lista = new List<string>();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Environment.CurrentDirectory;
            sfd.Title = "Guardar Configuracion";
            sfd.Filter = "Archivo | *.cfg";
            sfd.ShowDialog();

            StreamWriter escrito = new StreamWriter(sfd.FileName,false);

            #region Funciones
            Lista.Add(txtF1.Text + Environment.NewLine);
            Lista.Add(txtF2.Text + Environment.NewLine);
            Lista.Add(txtF3.Text + Environment.NewLine);
            Lista.Add(txtF4.Text + Environment.NewLine);
            Lista.Add(txtF5.Text + Environment.NewLine);
            Lista.Add(txtF6.Text + Environment.NewLine);
            Lista.Add(txtF7.Text + Environment.NewLine);
            Lista.Add(txtF8.Text + Environment.NewLine);
            Lista.Add(txtF9.Text + Environment.NewLine);
            Lista.Add(txtF10.Text + Environment.NewLine);
            Lista.Add(txtF11.Text + Environment.NewLine);
            Lista.Add(txtF12.Text + Environment.NewLine);
            #endregion
            #region Flechas
            Lista.Add(txtFleD.Text + Environment.NewLine);
            Lista.Add(txtFleR.Text + Environment.NewLine);
            Lista.Add(txtFleU.Text + Environment.NewLine);
            Lista.Add(txtFleL.Text + Environment.NewLine);
            #endregion
            #region Signos
            Lista.Add(txtAsterisco.Text + Environment.NewLine);
            Lista.Add(txtDivisor.Text + Environment.NewLine);
            Lista.Add(txtMenos.Text + Environment.NewLine);
            Lista.Add(txtMas.Text + Environment.NewLine);
            #endregion
            #region Numeros
            Lista.Add(txtNum0.Text + Environment.NewLine);
            Lista.Add(txtNum1.Text + Environment.NewLine);
            Lista.Add(txtNum2.Text + Environment.NewLine);
            Lista.Add(txtNum3.Text + Environment.NewLine);
            Lista.Add(txtNum4.Text + Environment.NewLine);
            Lista.Add(txtNum5.Text + Environment.NewLine);
            Lista.Add(txtNum6.Text + Environment.NewLine);
            Lista.Add(txtNum7.Text + Environment.NewLine);
            Lista.Add(txtNum8.Text + Environment.NewLine);
            Lista.Add(txtNum9.Text + Environment.NewLine);
            #endregion
            #region Teclado Numerico
            Lista.Add(txtTN0.Text + Environment.NewLine);
            Lista.Add(txtTN01.Text + Environment.NewLine);
            Lista.Add(txtTN02.Text + Environment.NewLine);
            Lista.Add(txtTN03.Text + Environment.NewLine);
            Lista.Add(txtTN04.Text + Environment.NewLine);
            Lista.Add(txtTN05.Text + Environment.NewLine);
            Lista.Add(txtTN06.Text + Environment.NewLine);
            Lista.Add(txtTN07.Text + Environment.NewLine);
            Lista.Add(txtTN08.Text + Environment.NewLine);
            Lista.Add(txtTN09.Text + Environment.NewLine);
            #endregion
            #region Letras
            Lista.Add(txtLetA.Text + Environment.NewLine);
            Lista.Add(txtLetB.Text + Environment.NewLine);
            Lista.Add(txtLetC.Text + Environment.NewLine);
            Lista.Add(txtLetD.Text + Environment.NewLine);
            Lista.Add(txtLetE.Text + Environment.NewLine);
            Lista.Add(txtLetF.Text + Environment.NewLine);
            Lista.Add(txtLetG.Text + Environment.NewLine);
            Lista.Add(txtLetH.Text + Environment.NewLine);
            Lista.Add(txtLetI.Text + Environment.NewLine);
            Lista.Add(txtLetJ.Text + Environment.NewLine);
            Lista.Add(txtLetK.Text + Environment.NewLine);
            Lista.Add(txtLetL.Text + Environment.NewLine);
            Lista.Add(txtLetM.Text + Environment.NewLine);
            Lista.Add(txtLetN.Text + Environment.NewLine);
            Lista.Add(txtLetO.Text + Environment.NewLine);
            Lista.Add(txtLetP.Text + Environment.NewLine);
            Lista.Add(txtLetQ.Text + Environment.NewLine);
            Lista.Add(txtLetR.Text + Environment.NewLine);
            Lista.Add(txtLetS.Text + Environment.NewLine);
            Lista.Add(txtLetT.Text + Environment.NewLine);
            Lista.Add(txtLetU.Text + Environment.NewLine);
            Lista.Add(txtLetV.Text + Environment.NewLine);
            Lista.Add(txtLetW.Text + Environment.NewLine);
            Lista.Add(txtLetX.Text + Environment.NewLine);
            Lista.Add(txtLetY.Text + Environment.NewLine);
            Lista.Add(txtLetZ.Text + Environment.NewLine);
            #endregion
            #region Secuencias
            Lista.Add(lista1.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia1.Text + Environment.NewLine);
            Lista.Add(lista2.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia2.Text + Environment.NewLine);
            Lista.Add(lista3.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia3.Text + Environment.NewLine);
            Lista.Add(lista4.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia4.Text + Environment.NewLine);
            Lista.Add(lista5.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia5.Text + Environment.NewLine);
            Lista.Add(lista6.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia6.Text + Environment.NewLine);
            Lista.Add(lista7.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia7.Text + Environment.NewLine);
            Lista.Add(lista8.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia8.Text + Environment.NewLine);
            Lista.Add(lista9.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia9.Text + Environment.NewLine);
            Lista.Add(lista10.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia10.Text + Environment.NewLine);
            Lista.Add(lista11.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia11.Text + Environment.NewLine);
            Lista.Add(lista12.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia12.Text + Environment.NewLine);
            Lista.Add(lista13.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia13.Text + Environment.NewLine);
            Lista.Add(lista14.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia14.Text + Environment.NewLine);
            Lista.Add(lista15.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia15.Text + Environment.NewLine);
            Lista.Add(lista16.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia16.Text + Environment.NewLine);
            Lista.Add(lista17.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia17.Text + Environment.NewLine);
            Lista.Add(lista18.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia18.Text + Environment.NewLine);
            Lista.Add(lista19.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia19.Text + Environment.NewLine);
            Lista.Add(lista20.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia20.Text + Environment.NewLine);
            Lista.Add(lista21.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia21.Text + Environment.NewLine);
            Lista.Add(lista22.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia22.Text + Environment.NewLine);
            Lista.Add(lista23.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia23.Text + Environment.NewLine);
            Lista.Add(lista24.SelectedIndex.ToString() + Environment.NewLine);
            Lista.Add(txtSecuencia24.Text + Environment.NewLine);
            #endregion

            for (int i = 0; i < 114; i++)
            {
                escrito.Write(Lista[i].ToString());
            }

            escrito.Flush();
            escrito.Close();            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            GuardarConfig();
        }

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Cargar Configuracion";
            ofd.Multiselect = false;
            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "Archivo | *.cfg";            
            ofd.ShowDialog();
            string[] lector = File.ReadAllLines(ofd.FileName);
            int conteo = 0;

            #region Funciones
            CargarConfig(txtF1, lector[conteo++]);
            CargarConfig(txtF2, lector[conteo++]);
            CargarConfig(txtF3, lector[conteo++]);
            CargarConfig(txtF4, lector[conteo++]);
            CargarConfig(txtF5, lector[conteo++]);
            CargarConfig(txtF6, lector[conteo++]);
            CargarConfig(txtF7, lector[conteo++]);
            CargarConfig(txtF8, lector[conteo++]);
            CargarConfig(txtF9, lector[conteo++]);
            CargarConfig(txtF10, lector[conteo++]);
            CargarConfig(txtF11, lector[conteo++]);
            CargarConfig(txtF12, lector[conteo++]);
            #endregion
            #region Flechas
            CargarConfig(txtFleD, lector[conteo++]);
            CargarConfig(txtFleR, lector[conteo++]);
            CargarConfig(txtFleU, lector[conteo++]);
            CargarConfig(txtFleL, lector[conteo++]);
            #endregion
            #region Simbolos
            CargarConfig(txtAsterisco, lector[conteo++]);
            CargarConfig(txtDivisor, lector[conteo++]);
            CargarConfig(txtMenos, lector[conteo++]);
            CargarConfig(txtMas, lector[conteo++]);
            #endregion
            #region Numeros
            CargarConfig(txtNum0, lector[conteo++]);
            CargarConfig(txtNum1, lector[conteo++]);
            CargarConfig(txtNum2, lector[conteo++]);
            CargarConfig(txtNum3, lector[conteo++]);
            CargarConfig(txtNum4, lector[conteo++]);
            CargarConfig(txtNum5, lector[conteo++]);
            CargarConfig(txtNum6, lector[conteo++]);
            CargarConfig(txtNum7, lector[conteo++]);
            CargarConfig(txtNum8, lector[conteo++]);
            CargarConfig(txtNum9, lector[conteo++]);
            #endregion
            #region Teclado Numerico
            CargarConfig(txtTN0, lector[conteo++]);
            CargarConfig(txtTN01, lector[conteo++]);
            CargarConfig(txtTN02, lector[conteo++]);
            CargarConfig(txtTN03, lector[conteo++]);
            CargarConfig(txtTN04, lector[conteo++]);
            CargarConfig(txtTN05, lector[conteo++]);
            CargarConfig(txtTN06, lector[conteo++]);
            CargarConfig(txtTN07, lector[conteo++]);
            CargarConfig(txtTN08, lector[conteo++]);
            CargarConfig(txtTN09, lector[conteo++]);
            #endregion
            #region Letras
            CargarConfig(txtLetA, lector[conteo++]);
            CargarConfig(txtLetB, lector[conteo++]);
            CargarConfig(txtLetC, lector[conteo++]);
            CargarConfig(txtLetD, lector[conteo++]);
            CargarConfig(txtLetE, lector[conteo++]);
            CargarConfig(txtLetF, lector[conteo++]);
            CargarConfig(txtLetG, lector[conteo++]);
            CargarConfig(txtLetH, lector[conteo++]);
            CargarConfig(txtLetI, lector[conteo++]);
            CargarConfig(txtLetJ, lector[conteo++]);
            CargarConfig(txtLetK, lector[conteo++]);
            CargarConfig(txtLetL, lector[conteo++]);
            CargarConfig(txtLetM, lector[conteo++]);
            CargarConfig(txtLetN, lector[conteo++]);
            CargarConfig(txtLetO, lector[conteo++]);
            CargarConfig(txtLetP, lector[conteo++]);
            CargarConfig(txtLetQ, lector[conteo++]);
            CargarConfig(txtLetR, lector[conteo++]);
            CargarConfig(txtLetS, lector[conteo++]);
            CargarConfig(txtLetT, lector[conteo++]);
            CargarConfig(txtLetU, lector[conteo++]);
            CargarConfig(txtLetV, lector[conteo++]);
            CargarConfig(txtLetW, lector[conteo++]);
            CargarConfig(txtLetX, lector[conteo++]);
            CargarConfig(txtLetY, lector[conteo++]);
            CargarConfig(txtLetZ, lector[conteo++]);
            #endregion
            #region Secuencias
            lista1.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia1, lector[conteo++]);
            lista2.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia2, lector[conteo++]);
            lista3.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia3, lector[conteo++]);
            lista4.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia4, lector[conteo++]);
            lista5.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia5, lector[conteo++]);
            lista6.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia6, lector[conteo++]);
            lista7.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia7, lector[conteo++]);
            lista8.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia8, lector[conteo++]);
            lista9.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia9, lector[conteo++]);
            lista10.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia10, lector[conteo++]);
            lista11.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia11, lector[conteo++]);
            lista12.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia12, lector[conteo++]);
            lista13.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia13, lector[conteo++]);
            lista14.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia14, lector[conteo++]);
            lista15.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia15, lector[conteo++]);
            lista16.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia16, lector[conteo++]);
            lista17.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia17, lector[conteo++]);
            lista18.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia18, lector[conteo++]);
            lista19.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia19, lector[conteo++]);
            lista20.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia20, lector[conteo++]);
            lista21.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia21, lector[conteo++]);
            lista22.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia22, lector[conteo++]);
            lista23.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia23, lector[conteo++]);
            lista24.SelectedIndex = Convert.ToInt32(lector[conteo++]);
            CargarConfig(txtSecuencia24, lector[conteo++]);
            #endregion
        }
        
        private void CargarConfig(TextBox TextBox, string Numero)
        {           
            TextBox.Text = Numero;
        }

        private void PulsarTecla(ComboBox Combo /*colocar dentro del recognizer*/)
        {                     
            if (Combo.SelectedItem.Equals("A"))
            {
                Teclas.pulsarTecla(Teclas.LetraA, Id);
                TimerProcesos();
            }

            if (Combo.SelectedItem.Equals("B"))
            {
                Teclas.pulsarTecla(Teclas.LetraB, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("C"))
            {
                Teclas.pulsarTecla(Teclas.LetraC, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("D"))
            {
                Teclas.pulsarTecla(Teclas.LetraD, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("E"))
            {
                Teclas.pulsarTecla(Teclas.LetraE, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F"))
            {
                Teclas.pulsarTecla(Teclas.LetraF, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("G"))
            {
                Teclas.pulsarTecla(Teclas.LetraG, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("H"))
            {
                Teclas.pulsarTecla(Teclas.LetraH, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("I"))
            {
                Teclas.pulsarTecla(Teclas.LetraI, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("J"))
            {
                Teclas.pulsarTecla(Teclas.LetraJ, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("K"))
            {
                Teclas.pulsarTecla(Teclas.LetraK, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("L"))
            {
                Teclas.pulsarTecla(Teclas.LetraL, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("M"))
            {
                Teclas.pulsarTecla(Teclas.LetraM, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("N"))
            {
                Teclas.pulsarTecla(Teclas.LetraN, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("O"))
            {
                Teclas.pulsarTecla(Teclas.LetraO, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("P"))
            {
                Teclas.pulsarTecla(Teclas.LetraP, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Q"))
            {
                Teclas.pulsarTecla(Teclas.LetraQ, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("R"))
            {
                Teclas.pulsarTecla(Teclas.LetraR, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("S"))
            {
                Teclas.pulsarTecla(Teclas.LetraS, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("T"))
            {
                Teclas.pulsarTecla(Teclas.LetraT, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("U"))
            {
                Teclas.pulsarTecla(Teclas.LetraU, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("V"))
            {
                Teclas.pulsarTecla(Teclas.LetraV, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("W"))
            {
                Teclas.pulsarTecla(Teclas.LetraW, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("X"))
            {
                Teclas.pulsarTecla(Teclas.LetraX, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Y"))
            {
                Teclas.pulsarTecla(Teclas.LetraY, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Z"))
            {
                Teclas.pulsarTecla(Teclas.LetraZ, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F1"))
            {
                Teclas.pulsarTecla(Teclas.VK_F1, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F2"))
            {
                Teclas.pulsarTecla(Teclas.VK_F2, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F3"))
            {
                Teclas.pulsarTecla(Teclas.VK_F3, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F4"))
            {
                Teclas.pulsarTecla(Teclas.VK_F4, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F5"))
            {
                Teclas.pulsarTecla(Teclas.VK_F5, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F6"))
            {
                Teclas.pulsarTecla(Teclas.VK_F6, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F7"))
            {
                Teclas.pulsarTecla(Teclas.VK_F7, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F8"))
            {
                Teclas.pulsarTecla(Teclas.VK_F8, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F9"))
            {
                Teclas.pulsarTecla(Teclas.VK_F9, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F10"))
            {
                Teclas.pulsarTecla(Teclas.VK_F10, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F11"))
            {
                Teclas.pulsarTecla(Teclas.VK_F11, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("F12"))
            {
                Teclas.pulsarTecla(Teclas.VK_F12, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad00"))
            {
                Teclas.pulsarTecla(Teclas.NumPad00, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad01"))
            {
                Teclas.pulsarTecla(Teclas.NumPad01, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad02"))
            {
                Teclas.pulsarTecla(Teclas.NumPad02, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad03"))
            {
                Teclas.pulsarTecla(Teclas.NumPad03, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad04"))
            {
                Teclas.pulsarTecla(Teclas.NumPad04, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad05"))
            {
                Teclas.pulsarTecla(Teclas.NumPad05, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad06"))
            {
                Teclas.pulsarTecla(Teclas.NumPad06, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad07"))
            {
                Teclas.pulsarTecla(Teclas.NumPad07, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad08"))
            {
                Teclas.pulsarTecla(Teclas.NumPad08, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("NumPad09"))
            {
                Teclas.pulsarTecla(Teclas.NumPad09, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN00"))
            {
                Teclas.pulsarTecla(Teclas.VkNum00, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN01"))
            {
                Teclas.pulsarTecla(Teclas.VkNum01, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN02"))
            {
                Teclas.pulsarTecla(Teclas.VkNum02, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN03"))
            {
                Teclas.pulsarTecla(Teclas.VkNum03, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN04"))
            {
                Teclas.pulsarTecla(Teclas.VkNum04, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN05"))
            {
                Teclas.pulsarTecla(Teclas.VkNum05, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN06"))
            {
                Teclas.pulsarTecla(Teclas.VkNum06, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN07"))
            {
                Teclas.pulsarTecla(Teclas.VkNum07, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN08"))
            {
                Teclas.pulsarTecla(Teclas.VkNum08, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("TN09"))
            {
                Teclas.pulsarTecla(Teclas.VkNum09, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Flecha Arriba"))
            {
                Teclas.pulsarTecla(Teclas.FlechaUp, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Flecha Abajo"))
            {
                Teclas.pulsarTecla(Teclas.FlechaDown, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Flecha Izquierda"))
            {
                Teclas.pulsarTecla(Teclas.FlechaLeft, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Flecha Derecha"))
            {
                Teclas.pulsarTecla(Teclas.FlechaRight, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("/"))
            {
                Teclas.pulsarTecla(Teclas.Divisor, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("*"))
            {
                Teclas.pulsarTecla(Teclas.Multiplicar, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("-"))
            {
                Teclas.pulsarTecla(Teclas.Menos, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("+"))
            {
                Teclas.pulsarTecla(Teclas.Suma, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Control"))
            {
                Teclas.pulsarTecla(Teclas.VK_CONTROL, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Alt"))
            {
                Teclas.pulsarTecla(Teclas.VK_ALT, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Shift"))
            {
                Teclas.pulsarTecla(Teclas.VK_SHIFT, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Espacio"))
            {
                Teclas.pulsarTecla(Teclas.VK_SPACE, Id);
                TimerProcesos();
            }
            if (Combo.SelectedItem.Equals("Enter"))
            {
                Teclas.pulsarTecla(Teclas.VK_ENTER, Id);
                TimerProcesos();
            }
        }

        private void AccionPulsar(ComboBox Combo)
        {
            if (Combo.SelectedItem.Equals("A"))
            {
                Teclas.pulsarTecla(Teclas.LetraA, Id);
            }

            if (Combo.SelectedItem.Equals("B"))
            {
                Teclas.pulsarTecla(Teclas.LetraB, Id);
            }
            if (Combo.SelectedItem.Equals("C"))
            {
                Teclas.pulsarTecla(Teclas.LetraC, Id);                
            }
            if (Combo.SelectedItem.Equals("D"))
            {
                Teclas.pulsarTecla(Teclas.LetraD, Id);                
            }
            if (Combo.SelectedItem.Equals("E"))
            {
                Teclas.pulsarTecla(Teclas.LetraE, Id);                
            }
            if (Combo.SelectedItem.Equals("F"))
            {
                Teclas.pulsarTecla(Teclas.LetraF, Id);                
            }
            if (Combo.SelectedItem.Equals("G"))
            {
                Teclas.pulsarTecla(Teclas.LetraG, Id);                
            }
            if (Combo.SelectedItem.Equals("H"))
            {
                Teclas.pulsarTecla(Teclas.LetraH, Id);                
            }
            if (Combo.SelectedItem.Equals("I"))
            {
                Teclas.pulsarTecla(Teclas.LetraI, Id);                
            }
            if (Combo.SelectedItem.Equals("J"))
            {
                Teclas.pulsarTecla(Teclas.LetraJ, Id);                
            }
            if (Combo.SelectedItem.Equals("K"))
            {
                Teclas.pulsarTecla(Teclas.LetraK, Id);                
            }
            if (Combo.SelectedItem.Equals("L"))
            {
                Teclas.pulsarTecla(Teclas.LetraL, Id);                
            }
            if (Combo.SelectedItem.Equals("M"))
            {
                Teclas.pulsarTecla(Teclas.LetraM, Id);                
            }
            if (Combo.SelectedItem.Equals("N"))
            {
                Teclas.pulsarTecla(Teclas.LetraN, Id);                
            }
            if (Combo.SelectedItem.Equals("O"))
            {
                Teclas.pulsarTecla(Teclas.LetraO, Id);                
            }
            if (Combo.SelectedItem.Equals("P"))
            {
                Teclas.pulsarTecla(Teclas.LetraP, Id);                
            }
            if (Combo.SelectedItem.Equals("Q"))
            {
                Teclas.pulsarTecla(Teclas.LetraQ, Id);                
            }
            if (Combo.SelectedItem.Equals("R"))
            {
                Teclas.pulsarTecla(Teclas.LetraR, Id);                
            }
            if (Combo.SelectedItem.Equals("S"))
            {
                Teclas.pulsarTecla(Teclas.LetraS, Id);                
            }
            if (Combo.SelectedItem.Equals("T"))
            {
                Teclas.pulsarTecla(Teclas.LetraT, Id);                
            }
            if (Combo.SelectedItem.Equals("U"))
            {
                Teclas.pulsarTecla(Teclas.LetraU, Id);                
            }
            if (Combo.SelectedItem.Equals("V"))
            {
                Teclas.pulsarTecla(Teclas.LetraV, Id);                
            }
            if (Combo.SelectedItem.Equals("W"))
            {
                Teclas.pulsarTecla(Teclas.LetraW, Id);                
            }
            if (Combo.SelectedItem.Equals("X"))
            {
                Teclas.pulsarTecla(Teclas.LetraX, Id);                
            }
            if (Combo.SelectedItem.Equals("Y"))
            {
                Teclas.pulsarTecla(Teclas.LetraY, Id);                
            }
            if (Combo.SelectedItem.Equals("Z"))
            {
                Teclas.pulsarTecla(Teclas.LetraZ, Id);                
            }
            if (Combo.SelectedItem.Equals("F1"))
            {
                Teclas.pulsarTecla(Teclas.VK_F1, Id);                
            }
            if (Combo.SelectedItem.Equals("F2"))
            {
                Teclas.pulsarTecla(Teclas.VK_F2, Id);                
            }
            if (Combo.SelectedItem.Equals("F3"))
            {
                Teclas.pulsarTecla(Teclas.VK_F3, Id);                
            }
            if (Combo.SelectedItem.Equals("F4"))
            {
                Teclas.pulsarTecla(Teclas.VK_F4, Id);                
            }
            if (Combo.SelectedItem.Equals("F5"))
            {
                Teclas.pulsarTecla(Teclas.VK_F5, Id);                
            }
            if (Combo.SelectedItem.Equals("F6"))
            {
                Teclas.pulsarTecla(Teclas.VK_F6, Id);                
            }
            if (Combo.SelectedItem.Equals("F7"))
            {
                Teclas.pulsarTecla(Teclas.VK_F7, Id);                
            }
            if (Combo.SelectedItem.Equals("F8"))
            {
                Teclas.pulsarTecla(Teclas.VK_F8, Id);                
            }
            if (Combo.SelectedItem.Equals("F9"))
            {
                Teclas.pulsarTecla(Teclas.VK_F9, Id);                
            }
            if (Combo.SelectedItem.Equals("F10"))
            {
                Teclas.pulsarTecla(Teclas.VK_F10, Id);                
            }
            if (Combo.SelectedItem.Equals("F11"))
            {
                Teclas.pulsarTecla(Teclas.VK_F11, Id);                
            }
            if (Combo.SelectedItem.Equals("F12"))
            {
                Teclas.pulsarTecla(Teclas.VK_F12, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad00"))
            {
                Teclas.pulsarTecla(Teclas.NumPad00, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad01"))
            {
                Teclas.pulsarTecla(Teclas.NumPad01, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad02"))
            {
                Teclas.pulsarTecla(Teclas.NumPad02, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad03"))
            {
                Teclas.pulsarTecla(Teclas.NumPad03, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad04"))
            {
                Teclas.pulsarTecla(Teclas.NumPad04, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad05"))
            {
                Teclas.pulsarTecla(Teclas.NumPad05, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad06"))
            {
                Teclas.pulsarTecla(Teclas.NumPad06, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad07"))
            {
                Teclas.pulsarTecla(Teclas.NumPad07, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad08"))
            {
                Teclas.pulsarTecla(Teclas.NumPad08, Id);                
            }
            if (Combo.SelectedItem.Equals("NumPad09"))
            {
                Teclas.pulsarTecla(Teclas.NumPad09, Id);                
            }
            if (Combo.SelectedItem.Equals("TN00"))
            {
                Teclas.pulsarTecla(Teclas.VkNum00, Id);                
            }
            if (Combo.SelectedItem.Equals("TN01"))
            {
                Teclas.pulsarTecla(Teclas.VkNum01, Id);                
            }
            if (Combo.SelectedItem.Equals("TN02"))
            {
                Teclas.pulsarTecla(Teclas.VkNum02, Id);                
            }
            if (Combo.SelectedItem.Equals("TN03"))
            {
                Teclas.pulsarTecla(Teclas.VkNum03, Id);                
            }
            if (Combo.SelectedItem.Equals("TN04"))
            {
                Teclas.pulsarTecla(Teclas.VkNum04, Id);                
            }
            if (Combo.SelectedItem.Equals("TN05"))
            {
                Teclas.pulsarTecla(Teclas.VkNum05, Id);                
            }
            if (Combo.SelectedItem.Equals("TN06"))
            {
                Teclas.pulsarTecla(Teclas.VkNum06, Id);                
            }
            if (Combo.SelectedItem.Equals("TN07"))
            {
                Teclas.pulsarTecla(Teclas.VkNum07, Id);                
            }
            if (Combo.SelectedItem.Equals("TN08"))
            {
                Teclas.pulsarTecla(Teclas.VkNum08, Id);                
            }
            if (Combo.SelectedItem.Equals("TN09"))
            {
                Teclas.pulsarTecla(Teclas.VkNum09, Id);                
            }
            if (Combo.SelectedItem.Equals("Flecha Arriba"))
            {
                Teclas.pulsarTecla(Teclas.FlechaUp, Id);                
            }
            if (Combo.SelectedItem.Equals("Flecha Abajo"))
            {
                Teclas.pulsarTecla(Teclas.FlechaDown, Id);                
            }
            if (Combo.SelectedItem.Equals("Flecha Izquierda"))
            {
                Teclas.pulsarTecla(Teclas.FlechaLeft, Id);                
            }
            if (Combo.SelectedItem.Equals("Flecha Derecha"))
            {
                Teclas.pulsarTecla(Teclas.FlechaRight, Id);                
            }
            if (Combo.SelectedItem.Equals("/"))
            {
                Teclas.pulsarTecla(Teclas.Divisor, Id);                
            }
            if (Combo.SelectedItem.Equals("*"))
            {
                Teclas.pulsarTecla(Teclas.Multiplicar, Id);                
            }
            if (Combo.SelectedItem.Equals("-"))
            {
                Teclas.pulsarTecla(Teclas.Menos, Id);                
            }
            if (Combo.SelectedItem.Equals("+"))
            {
                Teclas.pulsarTecla(Teclas.Suma, Id);                
            }
            if (Combo.SelectedItem.Equals("Control"))
            {
                Teclas.pulsarTecla(Teclas.VK_CONTROL, Id);                
            }
            if (Combo.SelectedItem.Equals("Alt"))
            {
                Teclas.pulsarTecla(Teclas.VK_ALT, Id);                
            }
            if (Combo.SelectedItem.Equals("Shift"))
            {
                Teclas.pulsarTecla(Teclas.VK_SHIFT, Id);                
            }
            if (Combo.SelectedItem.Equals("Espacio"))
            {
                Teclas.pulsarTecla(Teclas.VK_SPACE, Id);                
            }
            if (Combo.SelectedItem.Equals("Enter"))
            {
                Teclas.pulsarTecla(Teclas.VK_ENTER, Id);
            }
        }

        private void AccionSoltar(ComboBox Combo)
        {
            if (Combo.SelectedItem.Equals("A"))
            {
                Teclas.soltarTecla(Teclas.LetraA, Id);
            }
            if (Combo.SelectedItem.Equals("B"))
            {
                Teclas.soltarTecla(Teclas.LetraB, Id);
            }
            if (Combo.SelectedItem.Equals("C"))
            {
                Teclas.soltarTecla(Teclas.LetraC, Id);
            }
            if (Combo.SelectedItem.Equals("D"))
            {
                Teclas.soltarTecla(Teclas.LetraD, Id);
            }
            if (Combo.SelectedItem.Equals("E"))
            {
                Teclas.soltarTecla(Teclas.LetraE, Id);
            }
            if (Combo.SelectedItem.Equals("F"))
            {
                Teclas.soltarTecla(Teclas.LetraF, Id);
            }
            if (Combo.SelectedItem.Equals("G"))
            {
                Teclas.soltarTecla(Teclas.LetraG, Id);
            }
            if (Combo.SelectedItem.Equals("H"))
            {
                Teclas.soltarTecla(Teclas.LetraH, Id);
            }
            if (Combo.SelectedItem.Equals("I"))
            {
                Teclas.soltarTecla(Teclas.LetraI, Id);
            }
            if (Combo.SelectedItem.Equals("J"))
            {
                Teclas.soltarTecla(Teclas.LetraJ, Id);
            }
            if (Combo.SelectedItem.Equals("K"))
            {
                Teclas.soltarTecla(Teclas.LetraK, Id);
            }
            if (Combo.SelectedItem.Equals("L"))
            {
                Teclas.soltarTecla(Teclas.LetraL, Id);
            }
            if (Combo.SelectedItem.Equals("M"))
            {
                Teclas.soltarTecla(Teclas.LetraM, Id);
            }
            if (Combo.SelectedItem.Equals("N"))
            {
                Teclas.soltarTecla(Teclas.LetraN, Id);
            }
            if (Combo.SelectedItem.Equals("O"))
            {
                Teclas.soltarTecla(Teclas.LetraO, Id);
            }
            if (Combo.SelectedItem.Equals("P"))
            {
                Teclas.soltarTecla(Teclas.LetraP, Id);
            }
            if (Combo.SelectedItem.Equals("Q"))
            {
                Teclas.soltarTecla(Teclas.LetraQ, Id);
            }
            if (Combo.SelectedItem.Equals("R"))
            {
                Teclas.soltarTecla(Teclas.LetraR, Id);    
            }
            if (Combo.SelectedItem.Equals("S"))
            {
                Teclas.soltarTecla(Teclas.LetraS, Id);
            }
            if (Combo.SelectedItem.Equals("T"))
            {
                Teclas.soltarTecla(Teclas.LetraT, Id);
            }
            if (Combo.SelectedItem.Equals("U"))
            {
                Teclas.soltarTecla(Teclas.LetraU, Id);
            }
            if (Combo.SelectedItem.Equals("V"))
            {
                Teclas.soltarTecla(Teclas.LetraV, Id);
            }
            if (Combo.SelectedItem.Equals("W"))
            {
                Teclas.soltarTecla(Teclas.LetraW, Id);
            }
            if (Combo.SelectedItem.Equals("X"))
            {
                Teclas.soltarTecla(Teclas.LetraX, Id);
            }
            if (Combo.SelectedItem.Equals("Y"))
            {
                Teclas.soltarTecla(Teclas.LetraY, Id);
            }
            if (Combo.SelectedItem.Equals("Z"))
            {
                Teclas.soltarTecla(Teclas.LetraZ, Id);
            }
            if (Combo.SelectedItem.Equals("F1"))
            {
                Teclas.soltarTecla(Teclas.VK_F1, Id);
            }
            if (Combo.SelectedItem.Equals("F2"))
            {
                Teclas.soltarTecla(Teclas.VK_F2, Id);
            }
            if (Combo.SelectedItem.Equals("F3"))
            {
                Teclas.soltarTecla(Teclas.VK_F3, Id);
            }
            if (Combo.SelectedItem.Equals("F4"))
            {
                Teclas.soltarTecla(Teclas.VK_F4, Id);
            }
            if (Combo.SelectedItem.Equals("F5"))
            {
                Teclas.soltarTecla(Teclas.VK_F5, Id);
            }
            if (Combo.SelectedItem.Equals("F6"))
            {
                Teclas.soltarTecla(Teclas.VK_F6, Id);
            }
            if (Combo.SelectedItem.Equals("F7"))
            {
                Teclas.soltarTecla(Teclas.VK_F7, Id);
            }
            if (Combo.SelectedItem.Equals("F8"))
            {
                Teclas.soltarTecla(Teclas.VK_F8, Id);
            }
            if (Combo.SelectedItem.Equals("F9"))
            {
                Teclas.soltarTecla(Teclas.VK_F9, Id);
            }
            if (Combo.SelectedItem.Equals("F10"))
            {
                Teclas.soltarTecla(Teclas.VK_F10, Id);
            }
            if (Combo.SelectedItem.Equals("F11"))
            {
                Teclas.soltarTecla(Teclas.VK_F11, Id);
            }
            if (Combo.SelectedItem.Equals("F12"))
            {
                Teclas.soltarTecla(Teclas.VK_F12, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad00"))
            {
                Teclas.soltarTecla(Teclas.NumPad00, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad01"))
            {
                Teclas.soltarTecla(Teclas.NumPad01, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad02"))
            {
                Teclas.soltarTecla(Teclas.NumPad02, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad03"))
            {
                Teclas.soltarTecla(Teclas.NumPad03, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad04"))
            {
                Teclas.soltarTecla(Teclas.NumPad04, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad05"))
            {
                Teclas.soltarTecla(Teclas.NumPad05, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad06"))
            {
                Teclas.soltarTecla(Teclas.NumPad06, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad07"))
            {
                Teclas.soltarTecla(Teclas.NumPad07, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad08"))
            {
                Teclas.soltarTecla(Teclas.NumPad08, Id);
            }
            if (Combo.SelectedItem.Equals("NumPad09"))
            {
                Teclas.soltarTecla(Teclas.NumPad09, Id);
            }
            if (Combo.SelectedItem.Equals("TN00"))
            {
                Teclas.soltarTecla(Teclas.VkNum00, Id);
            }
            if (Combo.SelectedItem.Equals("TN01"))
            {
                Teclas.soltarTecla(Teclas.VkNum01, Id);
            }
            if (Combo.SelectedItem.Equals("TN02"))
            {
                Teclas.soltarTecla(Teclas.VkNum02, Id);
            }
            if (Combo.SelectedItem.Equals("TN03"))
            {
                Teclas.soltarTecla(Teclas.VkNum03, Id);
            }
            if (Combo.SelectedItem.Equals("TN04"))
            {
                Teclas.soltarTecla(Teclas.VkNum04, Id);
            }
            if (Combo.SelectedItem.Equals("TN05"))
            {
                Teclas.soltarTecla(Teclas.VkNum05, Id);  
            }
            if (Combo.SelectedItem.Equals("TN06"))
            {
                Teclas.soltarTecla(Teclas.VkNum06, Id);
            }
            if (Combo.SelectedItem.Equals("TN07"))
            {
                Teclas.soltarTecla(Teclas.VkNum07, Id);
            }
            if (Combo.SelectedItem.Equals("TN08"))
            {
                Teclas.soltarTecla(Teclas.VkNum08, Id);
            }
            if (Combo.SelectedItem.Equals("TN09"))
            {
                Teclas.soltarTecla(Teclas.VkNum09, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Arriba"))
            {
                Teclas.soltarTecla(Teclas.FlechaUp, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Abajo"))
            {
                Teclas.soltarTecla(Teclas.FlechaDown, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Izquierda"))
            {
                Teclas.soltarTecla(Teclas.FlechaLeft, Id);
            }
            if (Combo.SelectedItem.Equals("Flecha Derecha"))
            {
                Teclas.soltarTecla(Teclas.FlechaRight, Id);
            }
            if (Combo.SelectedItem.Equals("/"))
            {
                Teclas.soltarTecla(Teclas.Divisor, Id);
            }
            if (Combo.SelectedItem.Equals("*"))
            {
                Teclas.soltarTecla(Teclas.Multiplicar, Id);
            }
            if (Combo.SelectedItem.Equals("-"))
            {
                Teclas.soltarTecla(Teclas.Menos, Id);
            }
            if (Combo.SelectedItem.Equals("+"))
            {
                Teclas.soltarTecla(Teclas.Suma, Id);
            }
            if (Combo.SelectedItem.Equals("Control"))
            {
                Teclas.soltarTecla(Teclas.VK_CONTROL, Id);
            }
            if (Combo.SelectedItem.Equals("Alt"))
            {
                Teclas.soltarTecla(Teclas.VK_ALT, Id);
            }
            if (Combo.SelectedItem.Equals("Shift"))
            {
                Teclas.soltarTecla(Teclas.VK_SHIFT, Id);
            }
            if (Combo.SelectedItem.Equals("Espacio"))
            {
                Teclas.soltarTecla(Teclas.VK_SPACE, Id);
            }
            if (Combo.SelectedItem.Equals("Enter"))
            {
                Teclas.soltarTecla(Teclas.VK_ENTER, Id);
            }
        }
    }
}
