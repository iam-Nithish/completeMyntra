////

//    import {navbar, searchFunction} from "../components/navbar.js";
//    document.getElementById("navbar").innerHTML = navbar();

//    document.querySelector("#form").addEventListener("submit", handleFormSubmit);

//    searchFunction();

//    // Function to handle form submission
//    function handleFormSubmit(event) {
//        event.preventDefault(); // Prevent form default action (page reload)

//    const email = document.querySelector("#email").value.trim();  // Trim whitespace
//    const password = document.querySelector("#password").value.trim();

//    // Email validation
//    if (!email) {
//        alert("Please enter your email ID");
//    return false;
//    }

//    // Simple email validation pattern
//    const emailPattern = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
//    if (!emailPattern.test(email)) {
//        alert("Please enter a valid email address");
//    return false;
//    }

//    // Password validation
//    if (!password) {
//        alert("Please enter your password");
//    return false;
//    }

//    if (password.length < 6) {
//        alert("Password should be at least 6 characters long");
//    return false;
//    }

//    // If everything is valid, redirect to the new page (assuming login success)
//    window.location.href = "/index.html";
//    return true;
//}




////import { navbar, searchFunction } from "../components/navbar.js";

////// Inserting the navbar component
////document.getElementById("navbar").innerHTML = navbar();

////// Adding search functionality
////searchFunction();

////// Event listener for the form submission
////document.querySelector("#form").addEventListener("submit", mybtn1);

////// Function to handle form submission
////function mybtn1(event) {
////    event.preventDefault(); // Prevent the default form submission behavior

////    // Get values from the form fields
////    let email = document.querySelector("#email").value;
////    let password = document.querySelector("#password").value;
////    let role = document.querySelector("#role").value;

////    // Basic email validation
////    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
////    if (!email) {
////        alert("Please enter your email.");
////        return false;
////    }
////    if (!emailPattern.test(email)) {
////        alert("Please enter a valid email address.");
////        return false;
////    }

////    // Password validation
////    if (!password) {
////        alert("Please enter your password.");
////        return false;
////    }
////    if (password.length < 6) {
////        alert("Password must be at least 6 characters long.");
////        return false;
////    }

////    // Role validation (ensure the user selects a role)
////    if (!role) {
////        alert("Please select a role (Admin or User).");
////        return false;
////    }

////    // If all validations pass, redirect to a success page or dashboard
////    if (role === "admin") {
////        window.location.href = "admin_dashboard.html"; // Redirect to admin dashboard
////    } else {
////        window.location.href = "Index"; // Redirect to user dashboard
////    }

////    return true;
////}


//import {navbar,searchFunction} from "../components/navbar.js"
//document.getElementById("navbar").innerHTML=navbar();


//     document.querySelector("#form").addEventListener("submit", mybtn1)


//     searchFunction();
//function mybtn1(){
//  event.preventDefault()
//     let num=document.querySelector("#num").value

//     if(num==""){
//         alert("Plesae enter 10 digit mobile number");
//         return false;
//     }

//     if(isNaN(num)){
//         alert("Enter only digit")
//         return false;
//     }
//     if(num.length<10){
//         alert("Invalid mobile number !")
//         return false;
//     }
//     if(num.length>10){
//        alert("Invalid mobile number !")
//        return false;
//    }
//     if((num.charAt(0)!=9) && (num.charAt(0)!=8) && (num.charAt(0)!=7) && (num.charAt(0)!=6)){
//         alert("Please enter a valid mobile number");
//         return false;
//     }

//     else{
//         window.location.href="otp.html"
//         return true;


//     }

//}

//import { navbar, searchFunction } from "../components/navbar.js";

//// Inserting the navbar component
//document.getElementById("navbar").innerHTML = navbar();

//// Adding search functionality
//searchFunction();

//// Event listener for the form submission
//document.querySelector("#form").addEventListener("submit", mybtn1);

//// Function to handle form submission
//function mybtn1(event) {
//    event.preventDefault(); // Prevent the default form submission behavior

//    // Get values from the form fields
//    let email = document.querySelector("#email").value;
//    let password = document.querySelector("#password").value;
//    let role = document.querySelector("#role").value;

//    // Basic email validation
//    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//    if (!email) {
//        alert("Please enter your email.");
//        return false;
//    }
//    if (!emailPattern.test(email)) {
//        alert("Please enter a valid email address.");
//        return false;
//    }

//    // Password validation
//    if (!password) {
//        alert("Please enter your password.");
//        return false;
//    }
//    if (password.length < 6) {
//        alert("Password must be at least 6 characters long.");
//        return false;
//    }

//    // Role validation (ensure the user selects a role)
//    if (!role) {
//        alert("Please select a role (Admin or User).");
//        return false;
//    }

//    // If all validations pass, redirect to a success page or dashboard
//    if (role === "admin") {
//        window.location.href = "admin_dashboard.html"; // Redirect to admin dashboard
//    } else {
//        window.location.href = "user_dashboard.html"; // Redirect to user dashboard
//    }

//    return true;
//}
