// cart.js - simple cart using localStorage
function getCart(){ return JSON.parse(localStorage.getItem('bio_cart')||'[]'); }
function setCart(c){ localStorage.setItem('bio_cart', JSON.stringify(c)); }
function addToCart(id, title, price){
  const cart = getCart();
  cart.push({id, title, price});
  setCart(cart);
  alert(title + ' added to cart');
  updateCartCount();
}
function removeFromCart(index){
  const cart = getCart();
  cart.splice(index,1);
  setCart(cart);
  renderCart();
  updateCartCount();
}
function clearCart(){ localStorage.removeItem('bio_cart'); renderCart(); updateCartCount(); }
function updateCartCount(){
  // Could update a cart count UI if added
}
function renderCart(){
  const cart = getCart();
  const area = document.getElementById('cart-area');
  if(!area) return;
  if(cart.length===0){ area.innerHTML = '<p>Your cart is empty.</p>'; return; }
  let html = '<ul>';
  let total = 0;
  cart.forEach((it,i)=>{ html += `<li><strong>${it.title}</strong> — $${(it.price||0).toFixed(2)} <button class="btn-outline" onclick="removeFromCart(${i})">Remove</button></li>`; total += (it.price||0); });
  html += `</ul><p class="price">Total: $${total.toFixed(2)}</p><p><button class="btn" onclick="location.href='/checkout.html'">Checkout</button> <button class="btn-outline" onclick="clearCart()">Clear cart</button></p>`;
  area.innerHTML = html;
}
