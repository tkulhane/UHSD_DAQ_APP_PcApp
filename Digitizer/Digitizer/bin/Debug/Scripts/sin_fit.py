
import numpy, scipy.optimize
import sys
import pylab as plt

def fit_sin(tt, yy):
    '''Fit sin to the input time sequence, and return fitting parameters "amp", "omega", "phase", "offset", "freq", "period" and "fitfunc"'''
    tt = numpy.array(tt)
    yy = numpy.array(yy)
    ff = numpy.fft.fftfreq(len(tt), (tt[1]-tt[0]))   # assume uniform spacing
    Fyy = abs(numpy.fft.fft(yy))
    guess_freq = abs(ff[numpy.argmax(Fyy[1:])+1])   # excluding the zero frequency "peak", which is related to offset
    guess_amp = numpy.std(yy) * 2.**0.5
    guess_offset = numpy.mean(yy)
    guess = numpy.array([guess_amp, 2.*numpy.pi*guess_freq, 0., guess_offset])

    def sinfunc(t, A, w, p, c):  return A * numpy.sin(w*t + p) + c
    popt, pcov = scipy.optimize.curve_fit(sinfunc, tt, yy, p0=guess)
    A, w, p, c = popt
    p_d = numpy.rad2deg(p)

    if A < 0:
        A = A*(-1)
        p = p + numpy.pi

    f = w/(2.*numpy.pi)
    fitfunc = lambda t: A * numpy.sin(w*t + p) + c
    #return {"amp": A, "omega": w, "phase": p, "phase_deg": p_d, "offset": c, "freq": f, "period": 1./f, "fitfunc": fitfunc, "maxcov": numpy.max(pcov), "rawres": (guess,popt,pcov)}
    return {"amp": A, "omega": w, "phase": p, "phase_deg": p_d, "offset": c, "freq": f, "period": 1./f, "fitfunc": fitfunc, "maxcov": numpy.max(pcov) , "rawres": (guess,popt,pcov)}




file = "data.txt"

Fs = 3.2E9


with open(file) as f:
    data = f.read()
data = data.split(' ')

samples = []
for i in range(0, len(data)-1):
    samples.append(int(data[i]))

Ts = 1/Fs
L = len(samples)
time = numpy.arange(start=0, stop=(Ts*(L)), step=Ts)

sig_dc = numpy.mean(samples)
#samples = (samples - sig_dc)

#samples = samples + 100*(numpy.random.random(len(samples))-0.5)

res = fit_sin(time, samples)
print( "---Amplitude=%(amp)s \n---Freq=%(freq)s \n---AngularFreq=%(omega)s \n---Phase=%(phase)s \n---Phase_deg=%(phase_deg)s \n---Offset=%(offset)s \n---Max. Cov.=%(maxcov)s" % res )

time_2 = numpy.arange(start=0, stop=(Ts*(L)), step=(Ts/100))

error = samples - res["fitfunc"](time)
#error = abs(error)


plt.plot(time, samples, "-k", label="y", linewidth=2)
plt.plot(time, res["fitfunc"](time), "r-", label="y fit curve", linewidth=2)
plt.show()

plt.plot(time, error, "-k",)
#plt.hist(x=error, bins='auto', color='#0504aa', alpha=0.7, rwidth=0.85)
plt.show()





