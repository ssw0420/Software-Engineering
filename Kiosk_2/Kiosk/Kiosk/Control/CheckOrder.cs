using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.Control
{
    //주문하기 버튼 클릭 시 주문 상품 수량이 적절한지(1개 이상인지) 체크하는 제어 클래스
    internal class CheckOrder
    {
        //주문하기 버튼 클릭 시 주문 상품 수량이 적절한지(1개 이상인지) 체크하는 제어 클래스
        public void checkOrderCorrect(int totalProductTypes, int totalQuantity, int totalPrice, List<Panel> cartItems, List<Product> products, CustomerMainForm form)
        {
            if (totalProductTypes >= 1)
            {
                OrderCheckPopup orderCheckPopup = new OrderCheckPopup(totalProductTypes, totalQuantity, totalPrice, cartItems, products, form);
                orderCheckPopup.ShowDialog();
            }
            else MessageBox.Show("상품이 한 개 이상이어야 합니다!");
        }
    }
}
