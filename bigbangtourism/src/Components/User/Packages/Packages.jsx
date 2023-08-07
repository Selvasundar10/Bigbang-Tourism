import React, { useEffect, useState } from 'react';
import { Variable } from '../../Variable/Variable';
import axios from 'axios';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import './Packages.css'

const Packages = () => {
    const [Tours, setTours] = useState([])
    useEffect(() => {
        axios.get(Variable.package_url)
            .then(response => {
                // Handle the response data here
                setTours(response.data);
            })
            .catch(error => {
                // Handle any errors that occurred during the request
                console.error('Error:', error.message);
            });


    }, []); 

    return (
        <>

            <div>
                <p>fghjkl</p>
                {
                    Tours.map(item => (
                        <Card className='package-card'>
                            <CardMedia>
                                {item.tour_Image}
                            </CardMedia>

                            <CardContent>
                                {item.tour_Name}

                                <div>
                                    {item.tour_Location}
                                </div>
                                <div>
                                    {item.duration}
                                </div>
                                <div>
                                    {item.tourDescription}
                                </div>
                            </CardContent>
                        </Card>
                    ))
                }
            </div></>
    );
}

export default Packages;
