import React from 'react';
import emailjs from 'emailjs-com';
import './Mailer.css'; // Import the external CSS file

const serviceId = 'service_2n03h5r';
const templateId = 'template_ju0mfqi';
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

const Mailer = () => {
  return (
    <div className='query-mail'>
      <div className='map_img'>
        <img src='https://img.freepik.com/premium-vector/world-map-silhouette-digital-simple-grey-map-flat-style-vector-realistic-illustration-earth-isolated-white-background_176516-1332.jpg?size=626&ext=jpg&ga=GA1.2.1633141905.1688143026&semt=ais' alt='map-img'></img>
      </div>
      <div className="form-container">
        <h4 className='emailform-head'>If you have any queries, feel free to get in touch with us using the form below:</h4>
        <form onSubmit={sendEmail}>
          <div className="form-group">
            <label for="name">Name:</label>
            <input type="text" className="form-control" id="name" name="name" required placeholder='Name' />
          </div>

          <div className="form-group">
            <label htmlFor="user_email">Email:</label>
            <input type="email" className="form-control" id="user_email" name="user_email" required placeholder='Email' />
          </div>

          <div className="form-group">
            <label htmlFor="message">Message:</label>
            <textarea id="message" className="form-control" name="message" rows="5" required />
          </div>
<div>
          <input type="submit" class="mail-submit-btn" value="Send" /></div>
 
        </form>
      </div>
    </div>
  );
};

export default Mailer;
