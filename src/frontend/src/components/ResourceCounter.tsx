import React from 'react';
import { Typography, Box } from '@mui/material';

export const ResourceCounter = ({ name, value }: { name: string; value: number }) => (
  <Box sx={{ padding: 1 }}>
    <Typography variant="h6">{name}: {value}</Typography>
  </Box>
);