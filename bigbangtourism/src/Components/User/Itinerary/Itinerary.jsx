import React, { useState, useEffect } from 'react';
import UserNavbar from '../UserNavbar';
import Chatbot from '../../Features/Chatbot/Chatbot';
import axios from 'axios';
import { Variable } from '../../Variable/Variable';
import './Itinerary.css';
import ArrowBackIosSharpIcon from '@mui/icons-material/ArrowBackIosSharp';
import Hotel from '../Hotel/Hotel'
const Itinerary = () => {
  const [Itineraries, setItineraries] = useState([]);
  const [Tours, setTours] = useState([])

  const [Hotels, setHotels] = useState([])


  useEffect(() => {
    axios.get(Variable.itinerary_url)
      .then(response => {
        setItineraries(response.data.filter(x=>x.tour.tour_Id===2));
      })
      .catch(error => {
        console.error('Error:', error.message);
      });
  }, []);

  useEffect(() => {
      axios.get(Variable.package_url)
          .then(response => {
              setTours(response.data);
          })
          .catch(error => {
              console.error('Error:', error.message);
          });


  }, []);

  useEffect(() => {
    axios.get(Variable.hotel_url)
      .then(response => {
        setHotels(response.data.filter(x=>x.tour.tour_Id===2));
      })
      .catch(error => {
        console.error('Error:', error.message);
      });
  }, []);


  const expandContent = (index) => {
    const hiddenContent = document.getElementById(`hiddenContent-${index}`);
    hiddenContent.classList.remove('hidden');
  };

  {/* <div>
  

Tours.map(item => (
  <div>
    {item.tour_Image}

  </div>
   ))
  }
  </div> */}

return (
    <>
      <UserNavbar />
      <br /><br />
      {/* ... (Tours map) */}
      <div>
      <div className='itinerary'>
        {Itineraries.map((item, index) => (
          <div key={index} className="itinerary-item">
            <ArrowBackIosSharpIcon onClick={() => expandContent(index)} className="expand-icon" />
            <p className="day">Days:{item.days}</p>
            <div className="hidden" id={`hiddenContent-${index}`}>
              <div>
                {item.activities}
              </div>
            </div>
          </div>
        ))}
      </div>
      <div>
        <Hotel/>
      </div>
      <Chatbot/>
      </div>
    </> 
  );
}

export default Itinerary;


