TIMEOUT 1
C:
cd servidor
pm2 stop index.js
pm2 delete all

cmd /k