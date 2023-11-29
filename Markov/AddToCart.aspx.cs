using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using Markov.Logic;

namespace Markov
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["ProductID"];
            int productId;
            if (!String.IsNullOrEmpty(rawId) && int.TryParse(rawId, out productId))
            {
                using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
                {
                    usersShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }

            }
            else
            {
                Debug.Fail("Ошибка : мы никогда не сможем добраться до AddToCart.aspx без ProductID.");
                throw new Exception("Ошибка: загрузка AddToCartaspx без присвоения идентификатора ProductId запрещена.");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}
