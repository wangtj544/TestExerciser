#--*--uft8-*-
import os
from ssas.logic import RunTestSuite

if  __name__ == "__main__":
    start_dir = os.path.dirname(__file__)
    RunTestSuite().run(start_dir = start_dir)