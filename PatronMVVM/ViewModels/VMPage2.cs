using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PatronMVVM.Models;

using Xamarin.Forms;

namespace PatronMVVM.ViewModels
{
    public class VMPage2/*-> cambia por el nombre del nuevo VM*/: BaseViewModel //heredado de la clase BaseViewModel
    {
        #region VARIABLES
//        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMPage2/*-> cambia por el nombre del nuevo VM*/(INavigation navigation)

        {
            Navigation = navigation;/*se comporta como una página en navegación*/
        }
        public ObservableCollection<MProduct> Products { get; set; }
        public VMPage2()
        {
            Products = new ObservableCollection<MProduct>
            {
                new MProduct
                {
                     Name="Yogurt",
                     Price=2000,
                     Image="javimac.png",
                     HasOffer=false
                },
                new MProduct
                {
                     Name="Watermelon",
                     Price=1500,
                     Image="Frank.png",
                     HasOffer=false
                },
                new MProduct
                {
                     Name="Water Bottle",
                     Price=1200,
                     Image="Juan.png",
                     HasOffer=true,
                     OfferPrice=1000
                }
            };
        }
    

        #endregion

        #region CONTROLES


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

