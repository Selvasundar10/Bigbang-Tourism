import React from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import './UserHome.css';
import Mailer from '../../Features/Mailer/Mailer'
import UserNavbar from '../UserNavbar';
import Footer from '../Footer/Footer';
import Map from '../../Features/Map/Map';
import Chatbot from '../../Features/Chatbot/Chatbot'

const imageList = [
  {
    id: 1,
    alt: 'Trips',
    image: 'https://www.gtholidays.in/wp-content/uploads/2022/12/Abroad-Trips.png.webp',
    title: ' 40000+ Abroad Trips',
    description: 'For the last decade, GT Holidays have organized more than 30,000 international itineraries.'
  },
  {
    id: 2,
    alt: 'Spectacled Caiman',
    image: 'https://www.gtholidays.in/wp-content/uploads/2022/12/Experiences.png.webp',
    title: 'Handcrafted Experiences',
    description: 'Each and every itinerary is customized according to the taste of the customers.'
  },
  {
    id: 3,
    alt: 'African Elephant',
    image: 'https://www.gtholidays.in/wp-content/uploads/2022/12/Travelers.png.webp',
    title: '96% Happy Travelers',
    description: '... holds record of 96% customer satisfaction and all customers are retained with us.'
  },
  // Add more image objects as needed
];

export default function ImgMediaCard() {
  return (
    <div>

      <UserNavbar /><br/><br/>
<div>
      <div className='welcome-msg'>
      <div className='Tajmahal-img'>
        <img
          src='https://img.freepik.com/free-photo/mesmerizing-shot-famous-historic-taj-mahal-agra-india_181624-16028.jpg?size=626&ext=jpg&ga=GA1.2.1633141905.1688143026&semt=ais'
          alt='tajmahal_img'
        />
      </div>
      <div className='welcome-content'>
        <h3> Welcome to JourneyJive</h3>
        <p>
        JourneyJive Pvt. Ltd is a subsidiary of Sangam Group of Hotels, one of the biggest hotel chains in south Tamil
          Nadu. The Sangam Group of Hotels founded in 1968 has for forty years provided impeccable service and outstanding
          hospitality. It currently has 19 properties in Tamil Nadu. JourneyJive Pvt. Ltd built on this strong foundation
          aims to provide great customer satisfaction and an exemplary holiday experience. Planning a once in a lifetime
          holiday or a yearly corporate retreat? No problem! JourneyJive can get you what you want and in the minimal
          time. One of the best destination management companies in South India, it has the experience and infrastructure
          to handle any customer demand. In addition to destination management, JourneyJive also plans corporate tours,
          incentive trips, college/school excursions, business travel, arranges car/railway & hotel bookings and much,
          much more. Discover what makes JourneyJive and its offerings distinct from the rest of the pack and
          indispensable to its customers.
        </p>
      </div>
    </div><br/><br/>  
      <div className="home-card-container">
        {imageList.map((image) => (
          <Card key={image.id} className="user-card" >
            <CardMedia
              component="img"
              alt={image.alt}
              height="40"
              image={image.image}
              className="user-card-media"
              style={{ width: '30%' }}
            />
            <CardContent>
              <Typography gutterBottom variant="h5" component="div" className="user-card-title">{image.title}</Typography>
              <Typography variant="body2" color="text.secondary" className="user-card-description">{image.description}</Typography>
            </CardContent>
          </Card>
        ))}

      </div></div><br />
      <div>
        <Mailer></Mailer>
        <Chatbot/>
        <br /><br />
    </div>
      <div>
        <Map></Map>
      </div>
      <Footer />
    </div>
  );
}
