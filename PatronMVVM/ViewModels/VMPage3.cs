using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace PatronMVVM.ViewModels
{
    public class VMPage3/*-> cambia por el nombre del nuevo VM*/: BaseViewModel //heredado de la clase BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMPage3/*-> cambia por el nombre del nuevo VM*/(INavigation navigation)
        {
            Navigation = navigation;/*se comporta como una página en navegación*/
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; } //retorna información de tipo string
            set { SetValue(ref _Texto, value); }//recibe información de tipo string
        }
        #endregion

        #region PROCESOS
/*        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }*/
        #endregion

        #region COMANDOS
//        public ICommand ProcesoAsynccommand => new Command(async () => await ProcesoAsyncrono());//ejecuta la función que está en la región de procesos 
//        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}

