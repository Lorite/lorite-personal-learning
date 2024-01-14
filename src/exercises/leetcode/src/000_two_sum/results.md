| Language | Method iteration | Runtime (s) | Runtime Percentile (%) | Memory (MB) | Memory Percentile (%) | Notes                   |
| -------- | ---------------- | ----------- | ---------------------- | ----------- | --------------------- | ----------------------- |
| cpp      | V1               | 0.469       | 7.85                   | 10.5        | 79.07                 | No improvements         |
| cpp      | V1               | 0.419       | 11.19                  | 10.49       | 96.97                 | IMPR1: Save vector size on a variable     |
| cpp      | V1               | 0.250       | 40.90                  | 10.54       | 79.07                 | IMPR2: Change at to [] in std::vector     |
