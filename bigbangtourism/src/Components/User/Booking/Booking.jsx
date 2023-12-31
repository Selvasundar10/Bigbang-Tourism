import React from 'react';
import emailjs from 'emailjs-com';
import Payment from '../../Features/Payment/Payment';

const serviceId = 'service_2n03h5r';
const templateId = 'template_c6mehzb';
const userId = 'YOuM5KlWqQa7syJhh';

function sendEmail(e) {
  e.preventDefault();

  emailjs.sendForm(serviceId, templateId, e.target, userId)
    .then((res) => {
      console.log(res);
      alert('Email sent successfully!');
      e.target.reset(); // Reset the form after successful submission
    })
    .catch((err) => {
      console.log(err);
      alert('Failed to send email. Please try again.');
    });
}

const Booking = () => {
  return (
    <div className='query-mail'>
   
      <div className="form-container">
        <h4 className='emailform-head'></h4>
        <form onSubmit={sendEmail}>
          <div className="form-group">
            <label for="name">Name:</label>
            <input type="text" className="form-control" id="name" name="name" required placeholder='Name' />
          </div>

          <div className="form-group">
            <label htmlFor="user_email">Email:</label>
            <input type="email" className="form-control" id="user_email" name="user_email" required placeholder='Email' />
          </div>
          <div>
            <Payment/>
          </div>

<div>
          <input type="submit" class="mail-submit-btn" value="Send" /></div>
 
        </form>
      </div>
    </div>
  );
};

export default Booking;



