import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Variable } from '../../Variable/Variable';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import NearMeIcon from '@mui/icons-material/NearMe';
import Chatbot from '../../Features/Chatbot/Chatbot'
import LocationOnOutlinedIcon from '@mui/icons-material/LocationOnOutlined';
import ApartmentIcon from '@mui/icons-material/Apartment';
import './Hotel.css';


const Hotel = () => {

      const [Hotels, setHotels] = useState([])

      useEffect(() => {
            axios.get(Variable.hotel_url)
                  .then(response => {
                        setHotels(response.data.filter(x => x.tour.tour_Id === 2));
                  })
                  .catch(error => {
                        console.error('Error:', error.message);
                  });
      }, []);

      return (
            <>
                  <div className='hotel-card-container'>
                        {

                              Hotels.map(item => (
                                    <Card className='hotel-card'>
                                          <CardMedia>

                                                <Typography >
                                                      <img src={''} className='hotel-img' />


                                                </Typography>
                                          </CardMedia>
                                          <CardContent>
                                                <Typography>
                                                      <h6 className='hotel_name'>    <ApartmentIcon    />
                                                            {item.hotel_name}
                                                      </h6>
                                                </Typography>
                                                <Typography>
                                                      <p className='hotel_location'>    <LocationOnOutlinedIcon />
                                                            {item.location}
                                                      </p>
                                                </Typography>
                                                <Typography className='hotel_contact_details'>
                                                      {item.contact_details}
                                                </Typography>

                                                <Typography>
                                                      <p>                                                      {item.description}
                                                      </p>
                                                </Typography>
                                                <Typography>
                                                      {item.rating}
                                                </Typography>
                                          </CardContent>
                                          {/* <Button id='booking-btn' endIcon={<NearMeIcon />}>
                                    Send
                                </Button> */}
                                    </Card>
                              ))
                        }</div>

            </>
      );
}

export default Hotel;


