
import numpy, scipy.optimize
import sys
#import pylab as plt

import matplotlib
import matplotlib.pyplot as plt




#file = "data.txt"

file = "log_comm_debug_data.txt"



with open(file) as f:
    data = f.read()
data = data.split('\n')

samples = []
for i in range(0, len(data)-1):
    samples.append(int(data[i]))


#print(samples)

err = 0

last_val = samples[0]

for i in range (1, len(samples) ):
    val = samples[i]
    
    #print(samples[i])

    if (val - last_val ) != 1:
        err = err + 1
        print('i: {0}, error: {1} --- {2}'.format(i,last_val, val))


    last_val = val

print('\n: num of err: {0}'.format(err))
print(': num data: {0}'.format(len(samples)))
