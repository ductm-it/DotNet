const loadCart = async () => {
  let cartItemHTML = "";

  let cart = JSON.parse(localStorage.getItem("cart"));
  let renderHTMLPromise = cart.map(async (cartItem) => {
    let productId = cartItem.productId;
    let itemInfo = await fetch(`/api/ProductsAPI/${productId}`);
    itemInfo = await itemInfo.json();

    cartItemHTML += `<div class="ps-cart-item">
                                    <a class="ps-cart-item__close" href="#"></a>
                                    <div class="ps-cart-item__thumbnail">
                                    <a href="#"></a>
                                    <img src="${itemInfo.image}" alt=""></div>
                                    <div class="ps-cart-item__content">
                                        <a class="ps-cart-item__title" href="#">${
                                          itemInfo.productName
                                        }</a>
                                        <p><span>Quantity:<i>${
                                          cartItem.productAmount
                                        }</i></span><span>Total:<i>${
      itemInfo.price * cartItem.productAmount
    }</i></span></p>
                                    </div>
                                </div>`;
    return itemInfo.price * cartItem.productAmount;
  });
  let arrSubTotal = await Promise.all(renderHTMLPromise);
  $("#cartContent").empty();

  $("#cartContent").append(cartItemHTML);
  $("#numberOfItem").text(cart.length);
  $("#total").text(_.sum(arrSubTotal));
  $("#cartCount").text(cart.length);
};
const loadAmountProducts = (productId) => {
  let cart = JSON.parse(localStorage.getItem("cart"));
  let product = _.find(cart, ["productId", productId]);

  $("#productAmount").val(product.productAmount);
};

const loadAllCartInfo = async () => {
  let cart = JSON.parse(localStorage.getItem("cart"));
  let html = ``;
  let allCartPromise = _.map(cart, async (cartItem) => {
    let productId = cartItem.productId;
    let productInfo = await fetch(`/api/ProductsAPI/${productId}`);
    productInfo = await productInfo.json();
    html += `<tr id='productItem_${productId}'>
                    <td>
                      <div class="ps-product--cart">
                      <img src="${productInfo.image}" alt="">
                      <a href="/products/Details/${productId}">${
      productInfo.productName
    }</a></div>
                    </td>
                    <td>${productInfo.price}</td>
                    <td>
                      <div class="form-group--number">
                        <input disabled class="form-control" type="text" value="${
                          cartItem.productAmount
                        }">
                      </div>
                    </td>
                    <td><span class="total-row">${
                      productInfo.price * cartItem.productAmount
                    }</span></td>
                    <td>
                      <div onclick='removeProduct(${productId})' class="ps-cart-listing__remove"></div>
                    </td>
                  </tr>`;
    return productInfo.price * cartItem.productAmount;
  });
  let total = await Promise.all(allCartPromise);
  $("#totalCart").text(total);
  $("#allCartItems").empty();
  $("#allCartItems").append(html);
};

const loadPaymentForm = async () => {
  let html = ``;

  let cart = JSON.parse(localStorage.getItem("cart"));
  let allCartPromise = _.map(cart, async (cartItem) => {
    let productId = cartItem.productId;
    let productInfo = await fetch(`/api/ProductsAPI/${productId}`);
    productInfo = await productInfo.json();
    html += `<tr>
            <td>${productInfo.productName} x ${cartItem.productAmount}</td>
             <td>${productInfo.price * cartItem.productAmount}</td>
          </tr>
          `;
    return productInfo.price * cartItem.productAmount;
  });

  let total = await Promise.all(allCartPromise);
  total = _.sum(total);
  let discount = localStorage.getItem("discount");
  if (discount == null) {
    discount = 0;
  }
  html += ` <tr>
             <td>Total</td>
            <td>${total}</td>
          </tr>
          <tr>
             <td>Discount</td>
             <td>${discount}</td>
          </tr>
          <tr>
             <td>You will pay</td>
             <td>${total - discount}</td>
           </tr>`;
  $("#paymentForm").empty();
  $("#paymentForm").append(html);
  localStorage.setItem("originalMoney", total);
  localStorage.setItem("total", total - discount);
};
loadCart();
