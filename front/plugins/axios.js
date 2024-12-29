import axios from 'axios';

export default defineNuxtPlugin(() => {
  // Create an Axios instance
  const axiosInstance = axios.create({
    baseURL: 'http://localhost:5209/api', // Replace with your backend base URL
  });

  return {
    provide: {
      axios: axiosInstance, // This makes the Axios instance available globally
    },
  };
});
