document.addEventListener("DOMContentLoaded", function () {
    let slideIndex = 0;
    let slides = document.getElementsByClassName("image-slide");
    let timer;

    // Hiển thị slide đầu tiên khi trang được tải
    showSlides(slideIndex);

    // Điều khiển các nút Previous/Next
    function moveImageSlide(n) {
        clearTimeout(timer); // Xóa bộ đếm giờ khi người dùng click
        slideIndex += n;
        if (slideIndex >= slides.length) slideIndex = 0; // Quay lại slide đầu nếu vượt quá
        if (slideIndex < 0) slideIndex = slides.length - 1; // Quay lại slide cuối nếu nhỏ hơn 0
        showSlides(slideIndex);
    }

    // Hiển thị slide hiện tại
    function showSlides(n) {
        for (let i = 0; i < slides.length; i++) {
            slides[i].style.display = "none"; // Ẩn tất cả slide
        }
        slides[n].style.display = "block"; // Hiển thị slide hiện tại
        timer = setTimeout(function () {
            moveImageSlide(1); // Tự động chuyển slide sau 4 giây
        }, 4000);
    }

    // Gắn sự kiện cho các nút Previous và Next
    document.querySelector(".prev").addEventListener("click", function () {
        moveImageSlide(-1);
    });

    document.querySelector(".next").addEventListener("click", function () {
        moveImageSlide(1);
    });
});

