let navIcon = document.querySelector(".bars-icon");
let navSlashIcon = document.querySelector(".times-icon");
let nav = document.querySelector("nav");
navIcon.addEventListener("click", function () {
    nav.style.visibility = "visible";
    nav.style.height = "100vh";
});
navSlashIcon.addEventListener("click", function () {
    nav.style.visibility = "hidden";
    nav.style.height = "0vh";
});
