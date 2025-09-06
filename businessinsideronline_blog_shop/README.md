# Netlify Static Site — Business Insider Online

This is a static e-commerce–style site for selling blog posts, designed for deployment on Netlify.

Deployment steps:
1. Download the ZIP and extract the files.
2. Create a new site on Netlify (drag & drop the extracted folder to the Netlify Sites area).
3. Netlify will publish the static site. Forms submitted via the Checkout page appear in Netlify > Sites > Site settings > Forms.
4. Process orders manually and deliver content via email or file link.

Notes:
- The cart is stored in localStorage (browser). Orders are sent via Netlify Forms (checkout).
- For automated delivery, connect Netlify Forms to a Zapier/Make workflow or use Netlify Functions + external storage.
