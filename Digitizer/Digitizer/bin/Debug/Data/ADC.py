import numpy as np
import matplotlib.pyplot as plt
import sys
import spectrum

Fs = 3.2E9
window='hanning'

file = sys.argv[1]

with open(file) as f:
    data = f.read()
data = data.split(' ')

samples = []
for i in range(0, len(data)-1):
    samples.append(int(data[i]))

samples = np.asarray(samples)


spectrum.analyze(samples,12,1.0,Fs,'hanning')      
#spectrum.analyze(samples,12,1.0,Fs,'uniform')        

