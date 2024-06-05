using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kiosk
{
    internal class LoadProductDetail
    {
        //고객 메인 화면에서 상품 Panel을 클릭 시 제품 상세 팝업이 뜨는데,
        //그때 선택된 상품의 이름, 이미지, 별점, 가격 등을 가지고 오는 메서드
        public void LoadDetail(Product product, ProductDetailPopup popUp)
        {
            popUp.productNameLabel.Text = product.ProductName;
            popUp.productImagePbx.Image = Image.FromFile(product.ProductImgPath);
            popUp.productRatingLabel.Text = product.ProductRating.ToString();
            popUp.productPriceLabel.Text = product.ProductPrice.ToString();
            popUp.productContentLabel.Text = product.ProductContent;
        }

    }
}
