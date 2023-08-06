import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';

import { Navbar, Nav, Container, NavDropdown } from 'react-bootstrap';
import './UserNavbar.css';
import InstagramIcon from "@mui/icons-material/Instagram";
import YouTubeIcon from "@mui/icons-material/YouTube";
import PhoneInTalkIcon from '@mui/icons-material/PhoneInTalk';
import { Link } from 'react-router-dom';



const UserNavbar = () => {
  return (
    <div>
      <Container fluid className='nav-head'>
        <div>
          <InstagramIcon fontSize="large" sx={{ color: "#E1306C" }} className='nav-insta-icon'>
          <Link to="https://www.instagram.com/" target="_blank" rel="noopener noreferrer"/>
          </InstagramIcon>
          <YouTubeIcon fontSize="large" sx={{ color: "#FF0000" }} className='nav-youtube-icon' />
          <Link to="https://www.youtube.com/" target="_blank" rel="noopener noreferrer"/>
          <PhoneInTalkIcon></PhoneInTalkIcon>
          <Link to="tel:8098230289" className='contact-number'>80983230289</Link>
        </div>
      </Container>
      <Navbar expand="lg" className='nav'>
        <Container fluid>
          <Navbar.Brand>............</Navbar.Brand>
          <Navbar.Toggle aria-controls="navbar-nav" />
          <Navbar.Collapse id="user-nav">
            <Nav className="ms-auto" >
              <Link to ='mailer' className='user-nav-link'>Home</Link>
              <Link to ='payment' className='user-nav-link'>About Us</Link>

              <Link to ='.' className='user-nav-link'>Tours</Link>

              <Link to ='.' className='user-nav-link'>Login</Link>



              <NavDropdown title={<img src="path_to_profile_pic.jpg" alt="Profile" className="profile-pic" />} id="profile-dropdown">
                <NavDropdown.Item>Dashboard</NavDropdown.Item>
                <NavDropdown.Item>Logout</NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
      {/* <Footer/> */}
    </div>
  );
};

export default UserNavbar;
