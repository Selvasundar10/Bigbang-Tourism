

import React, { useState } from 'react';

const Payment = () => {
    const [amount, setAmount] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        if (amount === "") {
            alert('Amount cannot be empty');
        } else {
            var options = {
                key: "rzp_test_ZAqrKNkI2R6NvP",
                key_Secret: "FXoZralxcjLJGwvQzyBzoOrO",
                amount: amount * 100,
                currency: "INR",
                name: "Tourism",
                description: "for testing purpose",
                handler: function (response) {
                    alert(response.razorpay_payment_id);
                },
                prefill: {
                    name: "Sundar",
                    email: "tsksundar1045@Gmail.com",
                    contact: "8098230289",
                },
                notes: {
                    address: "Razorpay Corporate Office"
                },
                theme: {
                    color: "#057d8b"
                }
            };
            var pay = new window.Razorpay(options);
            pay.open();
        }
    }

    return (
        <div>
            <input type='text' value={amount} onChange={(e) => setAmount(e.target.value)} />
            <br />
            <button onClick={handleSubmit}>Submit</button>
        </div>
    );
}

export default Payment;
