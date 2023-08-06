import React from 'react';
import '@fortawesome/fontawesome-free/css/all.min.css';

const Footer = () => {
  const currentYear = new Date().getFullYear();

  return (
    <footer className="footer">
      <div className="container">
        <div className="row">
          <div className="col-md-4">
            <h4>About Us</h4>
            <p>Your Tourism Company is a leading travel agency offering unforgettable travel experiences to various destinations worldwide. We specialize in crafting customized tours that cater to the unique preferences and interests of our travelers. Whether you're an adventure seeker, a culture enthusiast, or simply looking for a relaxing getaway, we have the perfect itinerary for you.</p>
          </div>
          
          <div className="col-md-4">
            <h4>Contact Us</h4>
            <p><i className="fas fa-map-marker"></i> 123 Main Street, Shollinganallur, India</p>
            <p><i className="fas fa-phone"></i> +1 234 567 890</p>
            <p><i className="fas fa-envelope"></i> tsksundar1045@gmail.com</p>
          </div>
          <div className="col-md-4">
            <h4>Follow Us</h4>
            <div className="social-icons">
              <a href="https://www.facebook.com/" target="_blank" className="fab fa-facebook"></a>
              <a href="https://twitter.com/"  target="_blank" className="fab fa-twitter"></a>
              <a href="https://www.google.com/" target="_blank" className="fab fa-google"></a>
              <a href="https://www.youtube.com/" target="_blank" className="fab fa-youtube"></a>
              <a href="https://www.instagram.com/" target="_blank" className="fab fa-instagram"></a>
            </div>
          </div>
        </div>
      </div>
      <div className="bottom-bar">
        <div className="container">
          <div className="row">
            <div className="col-md-6">
              <p>&copy; {currentYear} Your Tourism Company. All rights reserved.</p>
            </div>
            <div className="col-md-6 text-md-right">
              <ul className="footer-links">
                <li><a href="#">Terms of Service</a></li>
                <li><a href="#">Privacy Policy</a></li>
                <li><a href="#">Cookie Policy</a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </footer>
  );
};

export default Footer;
