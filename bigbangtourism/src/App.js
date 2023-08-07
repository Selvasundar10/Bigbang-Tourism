import React from 'react';
import '@fortawesome/fontawesome-free/css/all.min.css';
import Mailer from './Components/Features/Mailer/Mailer';
import Login from './Components/Login/Login';
import Register from './Components/Register/Register';
import UserHome from './Components/User/User_Home/UserHome';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Chatbot from './Components/Features/Chatbot/Chatbot';
import Payment from './Components/Features/Payment/Payment';
import AdminNavar from './Components/Admin/AdminNavbar';
import Packages from './Components/User/Packages/Packages';
import AdminHome from './Components/Admin/AdminHome/AdminHome';
import Booking from './Components/User/Booking/Booking';
import OTP from './Components/Features/OTP/OTP';

const App = () => {
  return (
    <div>
      <BrowserRouter>
        <Routes>
        <Route path="/" element={<UserHome />} />

          <Route path="/mailer" element={<Mailer />} />
          <Route path="/userhome" element={<UserHome />} />
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login />} />
          <Route path="/chat" element={<Chatbot />} />
          <Route path="/payment" element={<Payment />} />
          <Route path="/admin-nav" element={<AdminNavar />} />
          <Route path="/package" element={<Packages />} />
          <Route path="/adminhome" element={<AdminHome />} />
          <Route path="/booking" element={<Booking />} />
          <Route path="/otp" element={<OTP />} />


        </Routes>
      </BrowserRouter>
    </div>
  );
};

export default App;
