import React, { useEffect, useState } from 'react';
import { Variable } from '../../Variable/Variable';
import axios from 'axios';
import './Packages.css';
import UserNavbar from '../UserNavbar';
import { Link } from 'react-router-dom'; // Import Link from react-router-dom
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import Chatbot from '../../Features/Chatbot/Chatbot';
import LocationOnOutlinedIcon from '@mui/icons-material/LocationOnOutlined';
import AccessTimeOutlinedIcon from '@mui/icons-material/AccessTimeOutlined';

const Packages = () => {
  const [Tours, setTours] = useState([]);

  useEffect(() => {
    axios.get(Variable.package_url)
      .then(response => {
        setTours(response.data);
      })
      .catch(error => {
        console.error('Error:', error.message);
      });
  }, []);

  return (
    <>
      <UserNavbar />
      <br /><br />
      <div className='custom-card-container'>
        {Tours.map(item => (
          // Use Link to navigate to Itinerary component with the selected tour ID as a parameter
          <Link key={item.tour_Id} to={`/itinerary/${item.tour_Id}`} className='package-link'>
            <Card className='package-card'>
              <CardMedia>
                <Typography>
                  <img src={`https://localhost:7290/Images/Tour/${item.tour_Image}`} className='package-img' />
                </Typography>
              </CardMedia>
              <CardContent>
                <Typography>
                  <h5 className='tour_location'>
                    <LocationOnOutlinedIcon />
                    {item.tour_Location}
                  </h5>
                </Typography>
                <Typography className='tour_name'>
                  {item.tour_Name}
                </Typography>
                <Typography>
                  <p className='tour_duration' style={{ marginTop: '10px' }}>
                    <AccessTimeOutlinedIcon id='clock' style={{ fontSize: '22px' }} />
                    {item.duration}
                  </p>
                </Typography>
              </CardContent>
            </Card>
          </Link>
        ))}
      </div>
      <Chatbot />
    </>
  );
}

export default Packages;
