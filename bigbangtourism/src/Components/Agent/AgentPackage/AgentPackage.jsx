import React, { useState } from 'react';
import axios from 'axios';
import { Variable } from '../../Variable/Variable';

const AdminPackage = () => {
  const data = { tour_Name: '', duration: '' , tour_Location:  '' , cost: '' };
  const [inputData, setInputData] = useState(data);

  const handleData = (e) => {
    setInputData({ ...inputData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    axios.post(Variable.packageDTO_url, inputData)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.error(error);
      });
  };

  return (
    <div>
      <form onSubmit={handleSubmit}>
        <input
          type="text"
          className="form__field"
          placeholder="Tour Name"
          name="tour_Name"
          value={inputData.tour_Name}
          onChange={handleData}
        />
        <input
          type="text"
          className="form__field"
          placeholder="Duration"
          name="duration"
          value={inputData.duration}
          onChange={handleData}
        />
         <input
          type="text"
          className="form__field"
          placeholder="Tour Name"
          name="tour_Name"
          value={inputData.tour_Name}
          onChange={handleData}
        />
         <input
          type="text"
          className="form__field"
          placeholder="Tour Name"
          name="tour_Name"
          value={inputData.tour_Name}
          onChange={handleData}
        />
        <button type="submit">
          <span>Submit</span>
        </button>
        
        
      </form>
    </div>
  );
};

export default AdminPackage;
