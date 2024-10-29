function searchByName() {
    let input = document.getElementById('search').value.toLowerCase();
    let items = document.getElementsByClassName('menu-item');

    Array.from(items).forEach(item => {
        let name = item.querySelector('h3').textContent.toLowerCase();
        item.style.display = name.includes(input) ? 'block' : 'none';
    });
}

function filterProducts() {
    let brandFilter = document.getElementById('brandFilter').value;
    let categoryFilter = document.getElementById('categoryFilter').value;
    let priceFilter = document.getElementById('priceFilter').value;
    let items = document.getElementsByClassName('menu-item');

    Array.from(items).forEach(item => {
        let brand = item.getAttribute('data-brand');
        let category = item.getAttribute('data-category');
        let price = parseFloat(item.querySelector('.price').textContent.replace(/[^\d]/g, ''));

        // Xử lý khoảng giá từ bộ lọc
        let [minPrice, maxPrice] = priceFilter.split('-').map(Number);

        // Kiểm tra điều kiện lọc
        let matchesBrand = !brandFilter || brand === brandFilter;
        let matchesCategory = !categoryFilter || category === categoryFilter;
        let matchesPrice = !priceFilter ||
            (price >= minPrice && (!maxPrice || price <= maxPrice));

        // Hiển thị hoặc ẩn sản phẩm dựa trên các bộ lọc
        if (matchesBrand && matchesCategory && matchesPrice) {
            item.style.display = 'block';
        } else {
            item.style.display = 'none';
        }
    });
}

function addToCart(dishId) {
    alert('Đã thêm món ăn vào giỏ hàng với ID: ' + dishId);
}
