

//Scroll function for buttons
const homeButton = document.querySelector('.oval-home');
const aboutButton = document.querySelector('.oval-about');
const contactButton = document.querySelector('.oval-contact');


homeButton.addEventListener('click', () => {
    document.getElementById('home').scrollIntoView({ behavior: 'smooth' });
});

aboutButton.addEventListener('click', () => {
    document.getElementById('about').scrollIntoView({ behavior: 'smooth' });
});

contactButton.addEventListener('click', () => {
    document.getElementById('contact').scrollIntoView({ behavior: 'smooth' });
});


// Date and Time for bar
function updateDateTime() {
    const now = new Date();

    
    const options = { month: '2-digit', day: '2-digit', year: 'numeric' };
    const formattedDate = now.toLocaleDateString(undefined, options);
    const formattedTime = now.toLocaleTimeString(undefined, { hour: '2-digit', minute: '2-digit' });

    
    document.getElementById('date-time').textContent = `${formattedDate} ${formattedTime}`;
}


setInterval(updateDateTime, 1000);
updateDateTime();



//Flip IMG in footer
document.addEventListener('DOMContentLoaded', () => {
    const circle = document.querySelector('.footer-flip .circle');
    const flipText = document.querySelector('.footer-flip .flip-text');

    
    const frontText = '"Your road, your reality"';
    const backText = '"Your keyboard, our throne"';

    
    circle.addEventListener('click', () => {
        circle.classList.toggle('flip'); 
        flipText.textContent = circle.classList.contains('flip') ? backText : frontText; 
    });
});