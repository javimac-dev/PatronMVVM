using PatronMVVM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace PatronMVVM.ViewModels
{
    public class VMPage1: BaseViewModel
    {
        #region VARIABLES
        /*string _mensaje;*/
        string _numero1;
        string _numero2;
        string _respuesta;
        string _datopicker;
        DateTime _fecha;
        string _resultadoFecha;
        #endregion

        #region CONSTRUCTOR
        public VMPage1(INavigation navigation)
        {
            Navigation = navigation;/*se comporta como una página en navegación*/
            dtePicker=DateTime.Now;
        }
        #endregion 

        #region CONTROLES
        public string txtNumero1
        {
            get { return _numero1; } //retorna información de tipo string
            set { SetValue(ref _numero1, value); }//recibe información de tipo string
        }

        public string txtNumero2
        {
            get { return _numero2; } //retorna información de tipo string
            set { SetValue(ref _numero2, value); }//recibe información de tipo string
        }

        public string lblRespuesta
        {
            get { return _respuesta; } //retorna información de tipo string
            set { SetValue(ref _respuesta, value); }//recibe información de tipo string
        }

        public string Datopicker
        {
            get { return _datopicker; } //retorna información de tipo string
            set { SetValue(ref _datopicker, value); }//recibe información de tipo string
        }
        public string cboxPicker //este es el nombre en el binding
        {
            get { return _datopicker; } 
            set 
            { 
                SetProperty(ref _datopicker, value);
                Datopicker = _datopicker;
            }
        }

        public DateTime dtePicker
        {
            get { return _fecha; } //retorna información de tipo datetime
            set 
            {
                SetValue(ref _fecha, value);
                lblResultadoFecha=_fecha.ToString("dd/MM/yyyy");
            }
        }

        public string lblResultadoFecha
        {
            get { return _resultadoFecha; } //retorna información de tipo string
            set { SetValue(ref _resultadoFecha, value); }//recibe información de tipo string
        }

        #endregion

        #region FUNCIONES
        public async Task fnPagina2()
        {
            await Navigation.PushAsync(new Page2());
        }

/*        public async Task procesoAsincrono()
        {
 
        }
*/

        public void fnSumar()
        {
            double _num1=0;
            double _num2=0;   
            double _resp = 0;
            _num1 = Convert.ToDouble(txtNumero1);
            _num2 = Convert.ToDouble(txtNumero2);
            _resp = _num1 + _num2;
            lblRespuesta = _resp.ToString();
        }
        #endregion

        #region COMANDOS
        public ICommand btnPagina2 => new Command(async () => await fnPagina2());//ejecuta la función que está en la región de procesos 
        public ICommand btnSumar => new Command(fnSumar);
        #endregion
    }
}
