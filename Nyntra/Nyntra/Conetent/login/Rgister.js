import { navbar, searchFunction } from "../components/navbar.js";

// Inserting the navbar component
document.getElementById("navbar").innerHTML = navbar();

// Adding search functionality
searchFunction();

// Event listener for the form submission
document.querySelector("#form").addEventListener("submit", mybtn1);

// Function to handle form submission
function mybtn1(event) {
    event.preventDefault(); // Prevent the default form submission behavior

    // Get values from the form fields
    let fullName = document.querySelector("#fullName").value;
    let email = document.querySelector("#email").value;
    let password = document.querySelector("#password").value;
    let confirmPassword = document.querySelector("#confirmPassword").value;
    let role = document.querySelector("#role").value;

    // Basic email validation
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailPattern.test(email)) {
        alert("Please enter a valid email address.");
        return false;
    }

    // Full name validation
    if (!fullName) {
        alert("Please enter your full name.");
        return false;
    }

    // Password validation
    if (password.length < 6) {
        alert("Password must be at least 6 characters long.");
        return false;
    }

    // Confirm password validation
    if (password !== confirmPassword) {
        alert("Passwords do not match. Please try again.");
        return false;
    }

    // Role validation (ensure the user selects a role)
    if (!role) {
        alert("Please select a role (Admin or User).");
        return false;
    }

    // If all validations pass, redirect to the login page
    alert("Registration successful! Redirecting to login page.");
    window.location.href = "login"; // Redirect to login page

    return true;
}