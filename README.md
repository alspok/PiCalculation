# PiCalculation
Program calculates math constants - pi, e, sqrt of 2 - double digits in two frames frequencies.
E.g. for pi 3.1415926535 8979323846... taking two series:
  14 15 92 65 35 89 79 32 38 46 ... and
  41 59 26 53 58 97 93 23 84 ...
then calculating frequencies of 00 ... 99 in each frames, getting didigits differencies and
summing abs values of them.
After shuffleing didigits in first frame few times recalculating series in same way.

Result for pi:

Series    Diff    Calc
length            time

10^5      0.0514  00:00:03
10^6      0.0175  00:07:00
2x10^6    0.0106  00:32:20
3x10^6    0.0087  01:28:58
4x10^6    0.0079  01:25:04
5x10^6    0.0062  02:14:44
6x10^6    0.0052  03:29:21
7x10^6    0.0056  04:38:07
8x10^6    0.0050  06:43:36

Shuffle of 10*6 serie:

0.0175
0.0169
0.0167
0.0159
0.0154
0.0151
0.0177
0.0161
0.0155
0.0167
0.0155
