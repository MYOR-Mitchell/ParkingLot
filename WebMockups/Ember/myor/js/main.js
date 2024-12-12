document.addEventListener('DOMContentLoaded', () => {
    const circle = document.querySelector('.footer-flip .circle');
    const flipText = document.querySelector('.footer-flip .flip-text');

    // Text for each side
    const frontText = '"Your road, your reality"';
    const backText = '"Your keyboard, our throne"';

    // Add click event listener
    circle.addEventListener('click', () => {
        circle.classList.toggle('flip'); // Toggle the flip effect
        flipText.textContent = circle.classList.contains('flip') ? backText : frontText; // Update text
    });
});

