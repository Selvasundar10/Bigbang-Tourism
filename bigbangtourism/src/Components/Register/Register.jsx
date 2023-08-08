import React, { useState } from 'react';
import Button from "@mui/material/Button";
import CssBaseline from "@mui/material/CssBaseline";
import TextField from "@mui/material/TextField";
import { Link } from 'react-router-dom';
import Paper from "@mui/material/Paper";
import Box from "@mui/material/Box";
import Grid from "@mui/material/Grid";
import Typography from "@mui/material/Typography";
import { Container } from "@mui/material";
import MenuItem from "@mui/material/MenuItem";
import axios from 'axios';

export default function RegisterSide() {
  const [formErrors, setFormErrors] = useState({});

  const handleSubmit = async (event) => {
    event.preventDefault();
    const data = new FormData(event.currentTarget);
    const errors = {};

    // Validate name (required)
    if (!data.get("name")) {
      errors.name = "Name is required";
    }

    // Validate email (required and email format)
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!data.get("email")) {
      errors.email = "Email is required";
    } else if (!emailRegex.test(data.get("email"))) {
      errors.email = "Invalid email format";
    }

    // Validate password (required)
    if (!data.get("password")) {
      errors.password = "Password is required";
    }

    // Validate role (required)
    if (!data.get("role")) {
      errors.role = "Role is required";
    }

    // Check if there are any errors
    if (Object.keys(errors).length > 0) {
      setFormErrors(errors);
      return;
    }

    try {
      console.log({
        user_Id: data.get("name"),
        email: data.get("email"),
        passwordClear: data.get("password"),
        role: data.get("role"),
      });
      // If no errors, send the form data to the server using Axios
      const role = data.get("role"); // Get the selected role

           // If no errors, send the form data to the server using Axios
        const response = await axios.post("https://localhost:7040/api/Users/Register", {
          user_Id: data.get("name"),
          user_Name: data.get("name"),
          email: data.get("email"),
          passwordClear: data.get("password"),
          role: role
        });
        localStorage.setItem("authToken", response.data.token);
                localStorage.setItem("Role", role);
        
                // Retrieve and print the token from local storage
                const storedToken = localStorage.getItem("authToken");
                console.log("Stored token:", storedToken);

      // Log the form data after successful submission
    

      // Do something after successful submission, e.g., show a success message
      console.log("Form data submitted successfully!");
    } catch (error) {
      // Handle error from Axios request
      console.error("Error submitting form:", error);
    }
  };

  return (
    <Container component="main" maxWidth="lg">
      <Box sx={{ marginTop: 8 }}>
        <Grid container>
          <CssBaseline />
          <Grid
            item
            xs={false}
            sm={4}
            md={7}
            style={{
              backgroundImage: "url(https://source.unsplash.com/random)",
              backgroundRepeat: "no-repeat",
              backgroundColor: (t) =>
                t.palette.mode === "light"
                  ? t.palette.grey[50]
                  : t.palette.grey[900],
              backgroundSize: "cover",
              backgroundPosition: "center",
            }}
          />
          <Grid
            item
            xs={12}
            sm={8}
            md={5}
            component={Paper}
            elevation={6}
            square
          >
            <Box
              sx={{
                my: 8,
                mx: 4,
                display: "flex",
                flexDirection: "column",
                alignItems: "center",
              }}
            >
              <Typography component="h1" variant="h5">
                Register
              </Typography>
              <Box
                component="form"
                noValidate
                onSubmit={handleSubmit}
                sx={{ mt: 1 }}
              >
                <TextField
                  margin="normal"
                  required
                  fullWidth
                  name="name"
                  label="Name"
                  type="text"
                  error={!!formErrors.name}
                  helperText={formErrors.name}
                />
                <TextField
                  margin="normal"
                  required
                  fullWidth
                  id="email"
                  label="Email Address"
                  name="email"
                  autoComplete="email"
                  autoFocus
                  error={!!formErrors.email}
                  helperText={formErrors.email}
                />
                <TextField
                  margin="normal"
                  required
                  fullWidth
                  name="password"
                  label="Password"
                  type="password"
                  id="password"
                  autoComplete="current-password"
                  error={!!formErrors.password}
                  helperText={formErrors.password}
                />
                <TextField
                  margin="normal"
                  required
                  fullWidth
                  select
                  name="role"
                  label="Role"
                  error={!!formErrors.role}
                  helperText={formErrors.role}
                >
                  <MenuItem value="Travel Agent">Travel Agent</MenuItem>
                  <MenuItem value="User">User</MenuItem>
                </TextField>
                
                <Button
                  type="submit"
                  fullWidth
                  variant="contained"
                  sx={{ mt: 3, mb: 2 }}
                >
                  Register
                </Button>
                <Grid container>
                  <Grid item>
                    <Link to='login' variant="body2">
                      {"Already have an account? Login"}
                    </Link>
                  </Grid>
                </Grid>
              </Box>
            </Box>
          </Grid>
        </Grid>
      </Box>
    </Container>
  );
}


// import React, { useState } from 'react';
// import Button from "@mui/material/Button";
// import CssBaseline from "@mui/material/CssBaseline";
// import TextField from "@mui/material/TextField";
// import Link from "@mui/material/Link";
// import Paper from "@mui/material/Paper";
// import Box from "@mui/material/Box";
// import Grid from "@mui/material/Grid";
// import Typography from "@mui/material/Typography";
// import { Container } from "@mui/material";
// import MenuItem from "@mui/material/MenuItem";
// import axios from 'axios';

// export default function RegisterSide() {
//   const [formErrors, setFormErrors] = useState({});

//   const handleSubmit = async (event) => {
//     event.preventDefault();
//     const data = new FormData(event.currentTarget);
//     const errors = {};

//     // Validate name (required)
//     if (!data.get("name")) {
//       errors.name = "Name is required";
//     }

//     // Validate email (required and email format)
//     const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
//     if (!data.get("email")) {
//       errors.email = "Email is required";
//     } else if (!emailRegex.test(data.get("email"))) {
//       errors.email = "Invalid email format";
//     }

//     // Validate password (required)
//     if (!data.get("password")) {
//       errors.password = "Password is required";
//     }

//     // Validate role (required)
//     if (!data.get("role")) {
//       errors.role = "Role is required";
//     }

//     // Check if there are any errors
//     if (Object.keys(errors).length > 0) {
//       setFormErrors(errors);
//       return;
//     }

//     try {
//       const role = data.get("role"); // Get the selected role

//       console.log({
//         user_Id: data.get("name"),
//         email: data.get("email"),
//         passwordClear: data.get("password"),
//         role: role,
//       });

//       if (role === "User") {
//         // If no errors, send the form data to the server using Axios
//         const response = await axios.post("https://localhost:7040/api/Users/Register", {
//           user_Id: data.get("name"),
//           user_Name: data.get("name"),
//           email: data.get("email"),
//           passwordClear: data.get("password"),
//           role: role
//         });

//         // Store the token and role in local storage
//         localStorage.setItem("authToken", response.data.token);
//         localStorage.setItem("Role", role);

//         // Retrieve and print the token from local storage
//         const storedToken = localStorage.getItem("authToken");
//         console.log("Stored token:", storedToken);

//         // Do something after successful submission, e.g., show a success message
//         console.log("Form data submitted successfully!");
//       } 
//       // else if (role === "Travel Agent") {
//       //   const response = await axios.post("https://localhost:7040/api/TravelAgents", {
//       //     agent_Id: data.get("name"),
//       //     agent_Name: data.get("name"),
//       //     email: data.get("email"),
//       //     password: data.get("password"),
//       //     role: role,
//       //     requestStatus:"request"
//       //   });

//       //   console.log("Travel Agent registration successful!");
//       // }
//     } catch (error) {
//       // Handle error from Axios request
//       console.error("Error submitting form:", error);
//     }
//   };

//   return (
//     <Container component="main" maxWidth="lg">
//       <Box sx={{ marginTop: 8 }}>
//         <Grid container>
//           <CssBaseline />
//           {/* ... Rest of the UI components ... */}
//         </Grid>
//       </Box>
//     </Container>
//   );
// }
