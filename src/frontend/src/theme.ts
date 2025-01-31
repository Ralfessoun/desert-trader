import { createTheme } from '@mui/material/styles';

export const darkTheme = createTheme({
  palette: {
    mode: 'dark',
    primary: {
      main: '#ffb74d', // Amber for desert vibes
    },
    background: {
      default: '#121212', // Deep dark background
    },
  },
});