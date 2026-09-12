document.querySelectorAll(".flip-card").forEach((card) => {
    card.addEventListener("keydown", (e) => {
        if (e.key === "Enter" || e.key === " ") {
            e.preventDefault();
            card.classList.toggle("flipped");
        }
    });
});