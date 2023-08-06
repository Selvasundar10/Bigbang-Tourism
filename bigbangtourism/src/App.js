import React from 'react';
import '@fortawesome/fontawesome-free/css/all.min.css';
import Mailer from './Components/Features/Mailer/Mailer';
import Login from './Components/Login/Login';
import Register from './Components/Register/Register';
import UserHome from './Components/User_Home/UserHome';
import 'bootstrap/dist/js/bootstrap.bundle.min.js';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import Chatbot from './Components/Features/Chatbot/Chatbot';
import Payment from './Components/Features/Payment/Payment';

const App = () => {
  return (
    <div>
      <BrowserRouter>
        <Routes>
          <Route path="/mailer" element={<Mailer />} />
          <Route path="/userhome" element={<UserHome />} />
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login />} />
          <Route path="/chat" element={<Chatbot />} />
          <Route path="/payment" element={<Payment />} />
          {/* The default route */}
          <Route path="/" element={<UserHome />} />
        </Routes>
      </BrowserRouter>
    </div>
  );
};

export default App;
