window.addEventListener('DOMContentLoaded', function () {
    const label = document.getElementById('header-label');
    const buttons = document.querySelectorAll('.match-height-btn');

    // Căn chiều cao button theo label
    if (label && buttons.length > 0) {
        const labelHeight = label.offsetHeight;
        buttons.forEach(button => {
            button.style.height = `${labelHeight}px`;
        });
    }
});
document.addEventListener("DOMContentLoaded", function () {
    const buttons = document.querySelectorAll('.match-height-btn');

    buttons.forEach(btn => {
        btn.addEventListener('click', function () {
            const url = this.getAttribute('data-action-url');
            fetchContent(url, this);
        });
    });

    // 👉 Gọi mặc định nút đầu tiên
    if (buttons.length > 0) {
        const defaultBtn = buttons[0];
        const defaultUrl = defaultBtn.getAttribute('data-action-url');
        fetchContent(defaultUrl, defaultBtn);
    }

    function fetchContent(url, btn) {
        fetch(url)
            .then(res => res.text())
            .then(html => {
                document.getElementById("main-content").innerHTML = html;

                // Active button
                buttons.forEach(b => b.classList.remove('active', 'fw-bold'));
                btn.classList.add('active', 'fw-bold');
            })
            .catch(err => console.error("Error loading content:", err));
    }
});

