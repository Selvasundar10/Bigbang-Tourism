import React from 'react';
import './Footer.css';

import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faFacebookF, faTwitter, faGooglePlusG, faTelegramPlane } from '@fortawesome/free-brands-svg-icons';
import { Link } from 'react-router-dom';


const Footer = () => {
    return (
        <div>

            <footer class="footer-section">
                <div class="container">
                    <div class="footer-cta pt-5 pb-5">
                        <div class="row">
                            <div class="col-xl-4 col-md-4 mb-30">
                                <div class="single-cta">
                                    <i class="fas fa-map-marker-alt"></i>
                                    <div class="cta-text">
                                        <h4>Find us</h4>
                                        <span>Rattha Tek Meadows, Tower – A, 1st Floor
                                            51, Rajiv Gandhi Salai (OMR)
                                            Sholinganallur, Chennai – 600119
                                            Tamil Nadu, India
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xl-4 col-md-4 mb-30">
                                <div class="single-cta">
                                    <i class="fas fa-phone"></i>
                                    <div class="cta-text">
                                        <h4>Call us</h4>
                                        <Link to="tel:8098230289" className='footer-contact'>80983230289</Link>
<br/>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xl-4 col-md-4 mb-30">
                                <div class="single-cta">
                                    <i class="far fa-envelope-open"></i>
                                    <div class="cta-text">
                                        <h4>Mail us</h4>
                                        <span>journyjive@info.com</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="footer-content pt-5 pb-5">
                        <div class="row">
                            <div class="col-xl-4 col-lg-4 mb-50">
                                <div class="footer-widget">

                                    <div class="footer-social-icon">
                                        <span>Follow us</span>
                                        <a href="#"><FontAwesomeIcon icon={faFacebookF} className="facebook-bg" /></a>
                                        <a href="#"><FontAwesomeIcon icon={faTwitter} className="twitter-bg" /></a>
                                        <a href="#"><FontAwesomeIcon icon={faGooglePlusG} className="google-bg" /></a>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xl-4 col-lg-4 col-md-6 mb-30">
                                <div class="footer-widget">
                                    <div class="footer-widget-heading">
                                        <h3>Useful Links</h3>
                                    </div>
                                    <ul>
                                        <li><a href="#">Home</a></li>
                                        <li><a href="#">about</a></li>
                                        <li><a href="#">services</a></li>
                                        <li><a href="#">portfolio</a></li>
                                        <li><a href="#">Contact</a></li>
                                        <li><a href="#">About us</a></li>
                                        <li><a href="#">Our Services</a></li>
                                        <li><a href="#">Expert Team</a></li>
                                        <li><a href="#">Contact us</a></li>
                                        <li><a href="#">Latest News</a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="col-xl-4 col-lg-4 col-md-6 mb-50">
                                <div class="footer-widget">
                                    <div class="footer-widget-heading">
                                        <h3>Subscribe</h3>
                                    </div>
                                    <div class="footer-text mb-25">
                                        <p>Don’t miss to subscribe to our new feeds, kindly fill the form below.</p>
                                    </div>
                                    <div class="subscribe-form">
                                        <form action="#">
                                            <input type="text" placeholder="Email Address" />
                                            <button><FontAwesomeIcon icon={faTelegramPlane} /></button>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="copyright-area">
                    <div class="container">
                        <div class="row">
                            <div class="col-xl-6 col-lg-6 text-center text-lg-left">
                                <div class="copyright-text">
                                    <p>Copyright &copy; 2023, All Right Reserved <a href="https://codepen.io/anupkumar92/">JourneyJive</a></p>
                                </div>
                            </div>
                            <div class="col-xl-6 col-lg-6 d-none d-lg-block text-right">
                                <div class="footer-menu">
                                    <ul>
                                        <li><a href="#">Home</a></li>
                                        <li><a href="#">Terms</a></li>
                                        <li><a href="#">Privacy</a></li>
                                        <li><a href="#">Policy</a></li>
                                        <li><a href="#">Contact</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
    )
}

export default Footer;