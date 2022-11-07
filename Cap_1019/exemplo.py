c = int(input())
for i in range(c):
  s = input().split()
  b = int(s[0])
  e = int(s[1])
  r = ""
  k = b
  while k <= e:
    r = r + str(k)
    k += 1
  s = r[::-1]
  print(r + s)  
    
