const updateCart = (productId) => {
  let productAmount = $("#productAmount").val();
  let currentCart = JSON.parse(localStorage.getItem("cart"));
  let newCartItem = {
    productId,
    productAmount,
  };
  if (currentCart == null) {
    currentCart = [];
    currentCart.push(newCartItem);
    localStorage.setItem("cart", JSON.stringify(currentCart));
    loadCart();
    return;
  }
  // check productId có trong cart chưa
  // nếu có rồi thì update số lượng
  let oldProduct = _.find(currentCart, ["productId", productId]);
  if (!_.isNil(oldProduct)) {
    _.remove(currentCart, function (n) {
      return n == oldProduct;
    });
  }
  currentCart.push(newCartItem);
  localStorage.setItem("cart", JSON.stringify(currentCart));
  loadCart();
  return;
};

const addAmount = (productId) => {
  let currentAmount = $("#productAmount").val();
  currentAmount++;
  $("#productAmount").val(currentAmount);
};
const minusAmount = (productId) => {
  let currentAmount = $("#productAmount").val();
  if (currentAmount == 1) return;
  currentAmount--;
  $("#productAmount").val(currentAmount);
};

const removeProduct = (productId) => {
  $(`#productItem_${productId}`).remove();
  let currentCart = JSON.parse(localStorage.getItem("cart"));
  let oldProduct = _.find(currentCart, ["productId", productId]);
  if (!_.isNil(oldProduct)) {
    _.remove(currentCart, function (n) {
      return n == oldProduct;
    });
  }
  localStorage.setItem("cart", JSON.stringify(currentCart));
  loadCart();
};

/**
call api to check promotion code
if code is valid, save discount money to localStorage
 */
const checkPromotionCode = async () => {
  let code = $("#voucherCode").val();
  if (code == "") {
    code = "a";
  }
  let codeInfo = await fetch(`/check/${code}`);
  codeInfo = await codeInfo.json();
  if (codeInfo.length > 0) {
    codeInfo = codeInfo[0];
    localStorage.setItem("discount", codeInfo.money);
    await fetch(`/useCode/${code}`);
  }

  location.href = `/checkout`;
};

const confirmOrder = async (e) => {
  // alert("submi");
  /**
  data : {
    cartt []

    discount
    customerInfo
  }
   */
  const cartUrl = "http://localhost:4000/dotnet/cart";
  let cart = JSON.parse(localStorage.getItem("cart"));
  let DiscountMoney = JSON.parse(localStorage.getItem("discount")) || 0;
  let Fullname = $("#fullName").val();
  let Email = $("#email").val();
  let Phone = $("#phone").val();
  let Address = $("#address").val();
  let originalMoney = JSON.parse(localStorage.getItem("originalMoney"));
  let total = localStorage.getItem("total");
  const rawResponse = await fetch(cartUrl, {
    method: "POST",
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    body: JSON.stringify({
      total,
      originalMoney,
      DiscountMoney,
      Fullname,
      Email,
      Phone,
      Address,
      cart,
    }),
  });
  localStorage.removeItem("discount");
  localStorage.removeItem("cart");
  localStorage.removeItem("total");
  localStorage.removeItem("originalMoney");
  $("#cartCount").text(0);

  location.href = "/thankyou";
};
