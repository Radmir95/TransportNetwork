using System;
using System.Web.UI;
using TransportNetwork.DataAccessLayer.Repository;

namespace TransportNetwork.WebApplication
{
    public partial class Tours : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var waybillRepository = new WaybillRepository();

                var waybills = waybillRepository.GetAllWaybills();
                ListOfProducts.DataSource = waybills;
                ListOfProducts.DataBind();

            }

        }
    }
}