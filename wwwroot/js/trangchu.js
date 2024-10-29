document.addEventListener('DOMContentLoaded', () => {
    const sliders = document.querySelectorAll('.product-slider');

    sliders.forEach(slider => {
        const sliderId = '#' + slider.id;
        startAutoplay(sliderId); // Khởi động autoplay cho mỗi slider

        slider.addEventListener('mouseenter', stopAutoplay); // Dừng autoplay khi hover
        slider.addEventListener('mouseleave', () => startAutoplay(sliderId));
    });
});

let slideInterval;

function nextSlide(sliderId) {
    const slider = document.querySelector(sliderId);
    const productWidth = slider.querySelector('.product-item1').clientWidth + 15; // Lấy chiều rộng sản phẩm + khoảng cách
    slider.style.transition = 'transform 0.5s ease-in-out';
    slider.style.transform = `translateX(-${productWidth * 4}px)`; // Chuyển đúng 4 sản phẩm

    setTimeout(() => {
        for (let i = 0; i < 4; i++) {
            slider.appendChild(slider.firstElementChild); // Di chuyển 4 sản phẩm đầu ra cuối
        }
        slider.style.transition = 'none';
        slider.style.transform = 'translateX(0)';
    }, 500);
}

function prevSlide(sliderId) {
    const slider = document.querySelector(sliderId);
    const productWidth = slider.querySelector('.product-item1').clientWidth + 15;

    for (let i = 0; i < 4; i++) {
        slider.insertBefore(slider.lastElementChild, slider.firstElementChild); // Di chuyển 4 sản phẩm cuối lên đầu
    }
    slider.style.transition = 'none';
    slider.style.transform = `translateX(-${productWidth * 4}px)`;

    setTimeout(() => {
        slider.style.transition = 'transform 0.5s ease-in-out';
        slider.style.transform = 'translateX(0)';
    }, 10);
}

function startAutoplay(sliderId) {
    slideInterval = setInterval(() => {
        nextSlide(sliderId);
    }, 3000); // Chuyển slide sau mỗi 3 giây
}

function stopAutoplay() {
    clearInterval(slideInterval);
}
