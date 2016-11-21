/*
 * MVCRestaurant
 * Comp229
 * Mudrak Patel
 * Javid Niftaliyeve
 */
(function () {
    console.log("app.css trigerred...");
    if (document.title === "Contact") {
        document.getElementById("facebookIcon").addEventListener("click", function () {
            window.open("https://www.facebook.com/Cafe-Society-Restaurant-110747838977294/");
        });

        document.getElementById("instagramIcon").addEventListener("click", function () {
            window.open("https://www.instagram.com/societycafe/");
        });

        document.getElementById("twitterIcon").addEventListener("click", function () {
            window.open("https://twitter.com/cafesocietyfilm?lang=en");
        });
    }
})();
