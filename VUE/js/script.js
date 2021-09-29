//Javascrip modale
// Enable tooltips
var tooltipTriggerList =
    [].slice.call(
        document.querySelectorAll('[data-toggle="tooltip"]'));
var tooltipList =
    tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });


let pg = document.querySelector('.page');
let menu = document.querySelector('.menu')
function showPage(page) {
    document.querySelectorAll('.page').forEach(page => {
        page.style.display = 'none';
    })

    document.querySelector(`#${page}`).style.display = 'block';
}

document.addEventListener('DOMContentLoaded', function () {
    let inp = document.querySelector('#tsear');
    let btnse = document.querySelector('#btnsear');
    btnse.onclick = function () {
    }
    
      document.querySelectorAll('.menu').forEach(menu => {
        menu.onclick = function () {
            showPage(this.dataset.page);
        }
    });


});