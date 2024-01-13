﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theoistic.Arxiv;

/// <summary>
/// This is a generated enum, please check https://arxiv.org/category_taxonomy
/// for any changes in categories, you can also use the string override.
/// </summary>
public enum ArxivCategory
{
    [Description("cs.AI - (Artificial Intelligence) - Covers all areas of AI except Vision, Robotics, Machine Learning, Multiagent Systems, and Computation and Language (Natural Language Processing), which have separate subject areas. In particular, includes Expert Systems, Theorem Proving (although this may overlap with Logic in Computer Science), Knowledge Representation, Planning, and Uncertainty in AI. Roughly includes material in ACM Subject Classes I.2.0, I.2.1, I.2.3, I.2.4, I.2.8, and I.2.11.")]
    ArtificialIntelligence,
    [Description("cs.AR - (Hardware Architecture) - Covers systems organization and hardware architecture. Roughly includes material in ACM Subject Classes C.0, C.1, and C.5.")]
    HardwareArchitecture,
    [Description("cs.CC - (Computational Complexity) - Covers models of computation, complexity classes, structural complexity, complexity tradeoffs, upper and lower bounds. Roughly includes material in ACM Subject Classes F.1 (computation by abstract devices), F.2.3 (tradeoffs among complexity measures), and F.4.3 (formal languages), although some material in formal languages may be more appropriate for Logic in Computer Science. Some material in F.2.1 and F.2.2, may also be appropriate here, but is more likely to have Data Structures and Algorithms as the primary subject area.")]
    ComputationalComplexity,
    [Description("cs.CE - (Computational Engineering, Finance, and Science) - Covers applications of computer science to the mathematical modeling of complex systems in the fields of science, engineering, and finance. Papers here are interdisciplinary and applications-oriented, focusing on techniques and tools that enable challenging computational simulations to be performed, for which the use of supercomputers or distributed computing platforms is often required. Includes material in ACM Subject Classes J.2, J.3, and J.4 (economics).")]
    ComputationalAndScience,
    [Description("cs.CG - (Computational Geometry) - Roughly includes material in ACM Subject Classes I.3.5 and F.2.2.")]
    ComputationalGeometry,
    [Description("cs.CL - (Computation and Language) - Covers natural language processing. Roughly includes material in ACM Subject Class I.2.7. Note that work on artificial languages (programming languages, logics, formal systems) that does not explicitly address natural-language issues broadly construed (natural-language processing, computational linguistics, speech, text retrieval, etc.) is not appropriate for this area.")]
    ComputationAndLanguage,
    [Description("cs.CR - (Cryptography and Security) - Covers all areas of cryptography and security including authentication, public key cryptosytems, proof-carrying code, etc. Roughly includes material in ACM Subject Classes D.4.6 and E.3.")]
    CryptographyAndSecurity,
    [Description("cs.CV - (Computer Vision and Pattern Recognition) - Covers image processing, computer vision, pattern recognition, and scene understanding. Roughly includes material in ACM Subject Classes I.2.10, I.4, and I.5.")]
    ComputerVisionAndPatternRecognition,
    [Description("cs.CY - (Computers and Society) - Covers impact of computers on society, computer ethics, information technology and public policy, legal aspects of computing, computers and education. Roughly includes material in ACM Subject Classes K.0, K.2, K.3, K.4, K.5, and K.7.")]
    ComputersAndSociety,
    [Description("cs.DB - (Databases) - Covers database management, datamining, and data processing. Roughly includes material in ACM Subject Classes E.2, E.5, H.0, H.2, and J.1.")]
    Databases,
    [Description("cs.DC - (Distributed, Parallel, and Cluster Computing) - Covers fault-tolerance, distributed algorithms, stabilility, parallel computation, and cluster computing. Roughly includes material in ACM Subject Classes C.1.2, C.1.4, C.2.4, D.1.3, D.4.5, D.4.7, E.1.")]
    AndClusterComputing,
    [Description("cs.DL - (Digital Libraries) - Covers all aspects of the digital library design and document and text creation. Note that there will be some overlap with Information Retrieval (which is a separate subject area). Roughly includes material in ACM Subject Classes H.3.5, H.3.6, H.3.7, I.7.")]
    DigitalLibraries,
    [Description("cs.DM - (Discrete Mathematics) - Covers combinatorics, graph theory, applications of probability. Roughly includes material in ACM Subject Classes G.2 and G.3.")]
    DiscreteMathematics,
    [Description("cs.DS - (Data Structures and Algorithms) - Covers data structures and analysis of algorithms. Roughly includes material in ACM Subject Classes E.1, E.2, F.2.1, and F.2.2.")]
    DataStructuresAndAlgorithms,
    [Description("cs.ET - (Emerging Technologies) - Covers approaches to information processing (computing, communication, sensing) and bio-chemical analysis based on alternatives to silicon CMOS-based technologies, such as nanoscale electronic, photonic, spin-based, superconducting, mechanical, bio-chemical and quantum technologies (this list is not exclusive). Topics of interest include (1) building blocks for emerging technologies, their scalability and adoption in larger systems, including integration with traditional technologies, (2) modeling, design and optimization of novel devices and systems, (3) models of computation, algorithm design and programming for emerging technologies.")]
    EmergingTechnologies,
    [Description("cs.FL - (Formal Languages and Automata Theory) - Covers automata theory, formal language theory, grammars, and combinatorics on words. This roughly corresponds to ACM Subject Classes F.1.1, and F.4.3. Papers dealing with computational complexity should go to cs.CC; papers dealing with logic should go to cs.LO.")]
    FormalLanguagesAndAutomataTheory,
    [Description("cs.GL - (General Literature) - Covers introductory material, survey material, predictions of future trends, biographies, and miscellaneous computer-science related material. Roughly includes all of ACM Subject Class A, except it does not include conference proceedings (which will be listed in the appropriate subject area).")]
    GeneralLiterature,
    [Description("cs.GR - (Graphics) - Covers all aspects of computer graphics. Roughly includes material in all of ACM Subject Class I.3, except that I.3.5 is is likely to have Computational Geometry as the primary subject area.")]
    Graphics,
    [Description("cs.GT - (Computer Science and Game Theory) - Covers all theoretical and applied aspects at the intersection of computer science and game theory, including work in mechanism design, learning in games (which may overlap with Learning), foundations of agent modeling in games (which may overlap with Multiagent systems), coordination, specification and formal methods for non-cooperative computational environments. The area also deals with applications of game theory to areas such as electronic commerce.")]
    ComputerScienceAndGameTheory,
    [Description("cs.HC - (Human-Computer Interaction) - Covers human factors, user interfaces, and collaborative computing. Roughly includes material in ACM Subject Classes H.1.2 and all of H.5, except for H.5.1, which is more likely to have Multimedia as the primary subject area.")]
    Interaction,
    [Description("cs.IR - (Information Retrieval) - Covers indexing, dictionaries, retrieval, content and analysis. Roughly includes material in ACM Subject Classes H.3.0, H.3.1, H.3.2, H.3.3, and H.3.4.")]
    InformationRetrieval,
    [Description("cs.IT - (Information Theory) - Covers theoretical and experimental aspects of information theory and coding. Includes material in ACM Subject Class E.4 and intersects with H.1.1.")]
    InformationTheory,
    [Description("cs.LG - (Machine Learning) - Papers on all aspects of machine learning research (supervised, unsupervised, reinforcement learning, bandit problems, and so on) including also robustness, explanation, fairness, and methodology. cs.LG is also an appropriate primary category for applications of machine learning methods.")]
    MachineLearning,
    [Description("cs.LO - (Logic in Computer Science) - Covers all aspects of logic in computer science, including finite model theory, logics of programs, modal logic, and program verification. Programming language semantics should have Programming Languages as the primary subject area. Roughly includes material in ACM Subject Classes D.2.4, F.3.1, F.4.0, F.4.1, and F.4.2; some material in F.4.3 (formal languages) may also be appropriate here, although Computational Complexity is typically the more appropriate subject area.")]
    LogicInComputerScience,
    [Description("cs.MA - (Multiagent Systems) - Covers multiagent systems, distributed artificial intelligence, intelligent agents, coordinated interactions. and practical applications. Roughly covers ACM Subject Class I.2.11.")]
    MultiagentSystems,
    [Description("cs.MM - (Multimedia) - Roughly includes material in ACM Subject Class H.5.1.")]
    Multimedia,
    [Description("cs.MS - (Mathematical Software) - Roughly includes material in ACM Subject Class G.4.")]
    MathematicalSoftware,
    [Description("cs.NA - (Numerical Analysis) - cs.NA is an alias for math.NA. Roughly includes material in ACM Subject Class G.1.")]
    NumericalAnalysis,
    [Description("cs.NE - (Neural and Evolutionary Computing) - Covers neural networks, connectionism, genetic algorithms, artificial life, adaptive behavior. Roughly includes some material in ACM Subject Class C.1.3, I.2.6, I.5.")]
    NeuralAndEvolutionaryComputing,
    [Description("cs.NI - (Networking and Internet Architecture) - Covers all aspects of computer communication networks, including network architecture and design, network protocols, and internetwork standards (like TCP/IP). Also includes topics, such as web caching, that are directly relevant to Internet architecture and performance. Roughly includes all of ACM Subject Class C.2 except C.2.4, which is more likely to have Distributed, Parallel, and Cluster Computing as the primary subject area.")]
    NetworkingAndInternetArchitecture,
    [Description("cs.OH - (Other Computer Science) - This is the classification to use for documents that do not fit anywhere else.")]
    OtherComputerScience,
    [Description("cs.OS - (Operating Systems) - Roughly includes material in ACM Subject Classes D.4.1, D.4.2., D.4.3, D.4.4, D.4.5, D.4.7, and D.4.9.")]
    OperatingSystems,
    [Description("cs.PF - (Performance) - Covers performance measurement and evaluation, queueing, and simulation. Roughly includes material in ACM Subject Classes D.4.8 and K.6.2.")]
    Performance,
    [Description("cs.PL - (Programming Languages) - Covers programming language semantics, language features, programming approaches (such as object-oriented programming, functional programming, logic programming). Also includes material on compilers oriented towards programming languages; other material on compilers may be more appropriate in Architecture (AR). Roughly includes material in ACM Subject Classes D.1 and D.3.")]
    ProgrammingLanguages,
    [Description("cs.RO - (Robotics) - Roughly includes material in ACM Subject Class I.2.9.")]
    Robotics,
    [Description("cs.SC - (Symbolic Computation) - Roughly includes material in ACM Subject Class I.1.")]
    SymbolicComputation,
    [Description("cs.SD - (Sound) - Covers all aspects of computing with sound, and sound as an information channel. Includes models of sound, analysis and synthesis, audio user interfaces, sonification of data, computer music, and sound signal processing. Includes ACM Subject Class H.5.5, and intersects with H.1.2, H.5.1, H.5.2, I.2.7, I.5.4, I.6.3, J.5, K.4.2.")]
    Sound,
    [Description("cs.SE - (Software Engineering) - Covers design tools, software metrics, testing and debugging, programming environments, etc. Roughly includes material in all of ACM Subject Classes D.2, except that D.2.4 (program verification) should probably have Logics in Computer Science as the primary subject area.")]
    SoftwareEngineering,
    [Description("cs.SI - (Social and Information Networks) - Covers the design, analysis, and modeling of social and information networks, including their applications for on-line information access, communication, and interaction, and their roles as datasets in the exploration of questions in these and other domains, including connections to the social and biological sciences. Analysis and modeling of such networks includes topics in ACM Subject classes F.2, G.2, G.3, H.2, and I.2; applications in computing include topics in H.3, H.4, and H.5; and applications at the interface of computing and other disciplines include topics in J.1--J.7. Papers on computer communication systems and network protocols (e.g. TCP/IP) are generally a closer fit to the Networking and Internet Architecture (cs.NI) category.")]
    SocialAndInformationNetworks,
    [Description("cs.SY - (Systems and Control) - cs.SY is an alias for eess.SY. This section includes theoretical and experimental research covering all facets of automatic control systems. The section is focused on methods of control system analysis and design using tools of modeling, simulation and optimization. Specific areas of research include nonlinear, distributed, adaptive, stochastic and robust control in addition to hybrid and discrete event systems. Application areas include automotive and aerospace control systems, network control, biological systems, multiagent and cooperative control, robotics, reinforcement learning, sensor networks, control of cyber-physical and energy-related systems, and control of computing systems.")]
    SystemsAndControl,
    [Description("econ.EM - (Econometrics) - Econometric Theory, Micro-Econometrics, Macro-Econometrics, Empirical Content of Economic Relations discovered via New Methods, Methodological Aspects of the Application of Statistical Inference to Economic Data.")]
    Econometrics,
    [Description("econ.GN - (General Economics) - General methodological, applied, and empirical contributions to economics.")]
    GeneralEconomics,
    [Description("econ.TH - (Theoretical Economics) - Includes theoretical contributions to Contract Theory, Decision Theory, Game Theory, General Equilibrium, Growth, Learning and Evolution, Macroeconomics, Market and Mechanism Design, and Social Choice.")]
    TheoreticalEconomics,
    [Description("eess.AS - (Audio and Speech Processing) - Theory and methods for processing signals representing audio, speech, and language, and their applications. This includes analysis, synthesis, enhancement, transformation, classification and interpretation of such signals as well as the design, development, and evaluation of associated signal processing systems. Machine learning and pattern analysis applied to any of the above areas is also welcome.  Specific topics of interest include: auditory modeling and hearing aids; acoustic beamforming and source localization; classification of acoustic scenes; speaker separation; active noise control and echo cancellation; enhancement; de-reverberation; bioacoustics; music signals analysis, synthesis and modification; music information retrieval;  audio for multimedia and joint audio-video processing; spoken and written language modeling, segmentation, tagging, parsing, understanding, and translation; text mining; speech production, perception, and psychoacoustics; speech analysis, synthesis, and perceptual modeling and coding; robust speech recognition; speaker recognition and characterization; deep learning, online learning, and graphical models applied to speech, audio, and language signals; and implementation aspects ranging from system architecture to fast algorithms.")]
    AudioAndSpeechProcessing,
    [Description("eess.IV - (Image and Video Processing) - Theory, algorithms, and architectures for the formation, capture, processing, communication, analysis, and display of images, video, and multidimensional signals in a wide variety of applications. Topics of interest include: mathematical, statistical, and perceptual image and video modeling and representation; linear and nonlinear filtering, de-blurring, enhancement, restoration, and reconstruction from degraded, low-resolution or tomographic data; lossless and lossy compression and coding; segmentation, alignment, and recognition; image rendering, visualization, and printing; computational imaging, including ultrasound, tomographic and magnetic resonance imaging; and image and video analysis, synthesis, storage, search and retrieval.")]
    ImageAndVideoProcessing,
    [Description("eess.SP - (Signal Processing) - Theory, algorithms, performance analysis and applications of signal and data analysis, including physical modeling, processing, detection and parameter estimation, learning, mining, retrieval, and information extraction. The term 'signal' includes speech, audio, sonar, radar, geophysical, physiological, (bio-) medical, image, video, and multimodal natural and man-made signals, including communication signals and data. Topics of interest include: statistical signal processing, spectral estimation and system identification; filter design, adaptive filtering / stochastic learning; (compressive) sampling, sensing, and transform-domain methods including fast algorithms; signal processing for machine learning and machine learning for signal processing applications; in-network and graph signal processing; convex and nonconvex optimization methods for signal processing applications; radar, sonar, and sensor array beamforming and direction finding; communications signal processing; low power, multi-core and system-on-chip signal processing; sensing, communication, analysis and optimization for cyber-physical systems such as power grids and the Internet of Things.")]
    SignalProcessing,
    [Description("eess.SY - (Systems and Control) - This section includes theoretical and experimental research covering all facets of automatic control systems. The section is focused on methods of control system analysis and design using tools of modeling, simulation and optimization. Specific areas of research include nonlinear, distributed, adaptive, stochastic and robust control in addition to hybrid and discrete event systems. Application areas include automotive and aerospace control systems, network control, biological systems, multiagent and cooperative control, robotics, reinforcement learning, sensor networks, control of cyber-physical and energy-related systems, and control of computing systems.")]
    SystemsAndControl_eess,
    [Description("math.AC - (Commutative Algebra) - Commutative rings, modules, ideals, homological algebra, computational aspects, invariant theory, connections to algebraic geometry and combinatorics")]
    CommutativeAlgebra,
    [Description("math.AG - (Algebraic Geometry) - Algebraic varieties, stacks, sheaves, schemes, moduli spaces, complex geometry, quantum cohomology")]
    AlgebraicGeometry,
    [Description("math.AP - (Analysis of PDEs) - Existence and uniqueness, boundary conditions, linear and non-linear operators, stability, soliton theory, integrable PDE's, conservation laws, qualitative dynamics")]
    AnalysisOfPdes,
    [Description("math.AT - (Algebraic Topology) - Homotopy theory, homological algebra, algebraic treatments of manifolds")]
    AlgebraicTopology,
    [Description("math.CA - (Classical Analysis and ODEs) - Special functions, orthogonal polynomials, harmonic analysis, ODE's, differential relations, calculus of variations, approximations, expansions, asymptotics")]
    ClassicalAnalysisAndOdes,
    [Description("math.CO - (Combinatorics) - Discrete mathematics, graph theory, enumeration, combinatorial optimization, Ramsey theory, combinatorial game theory")]
    Combinatorics,
    [Description("math.CT - (Category Theory) - Enriched categories, topoi, abelian categories, monoidal categories, homological algebra")]
    CategoryTheory,
    [Description("math.CV - (Complex Variables) - Holomorphic functions, automorphic group actions and forms, pseudoconvexity, complex geometry, analytic spaces, analytic sheaves")]
    ComplexVariables,
    [Description("math.DG - (Differential Geometry) - Complex, contact, Riemannian, pseudo-Riemannian and Finsler geometry, relativity, gauge theory, global analysis")]
    DifferentialGeometry,
    [Description("math.DS - (Dynamical Systems) - Dynamics of differential equations and flows, mechanics, classical few-body problems, iterations, complex dynamics, delayed differential equations")]
    DynamicalSystems,
    [Description("math.FA - (Functional Analysis) - Banach spaces, function spaces, real functions, integral transforms, theory of distributions, measure theory")]
    FunctionalAnalysis,
    [Description("math.GM - (General Mathematics) - Mathematical material of general interest, topics not covered elsewhere")]
    GeneralMathematics,
    [Description("math.GN - (General Topology) - Continuum theory, point-set topology, spaces with algebraic structure, foundations, dimension theory, local and global properties")]
    GeneralTopology,
    [Description("math.GR - (Group Theory) - Finite groups, topological groups, representation theory, cohomology, classification and structure")]
    GroupTheory,
    [Description("math.GT - (Geometric Topology) - Manifolds, orbifolds, polyhedra, cell complexes, foliations, geometric structures")]
    GeometricTopology,
    [Description("math.HO - (History and Overview) - Biographies, philosophy of mathematics, mathematics education, recreational mathematics, communication of mathematics, ethics in mathematics")]
    HistoryAndOverview,
    [Description("math.IT - (Information Theory) - math.IT is an alias for cs.IT. Covers theoretical and experimental aspects of information theory and coding.")]
    InformationTheory_math,
    [Description("math.KT - (K-Theory and Homology) - Algebraic and topological K-theory, relations with topology, commutative algebra, and operator algebras")]
    AndHomology,
    [Description("math.LO - (Logic) - Logic, set theory, point-set topology, formal mathematics")]
    Logic,
    [Description("math.MG - (Metric Geometry) - Euclidean, hyperbolic, discrete, convex, coarse geometry, comparisons in Riemannian geometry, symmetric spaces")]
    MetricGeometry,
    [Description("math.MP - (Mathematical Physics) - math.MP is an alias for math-ph. Articles in this category focus on areas of research that illustrate the application of mathematics to problems in physics, develop mathematical methods for such applications, or provide mathematically rigorous formulations of existing physical theories. Submissions to math-ph should be of interest to both physically oriented mathematicians and mathematically oriented physicists; submissions which are primarily of interest to theoretical physicists or to mathematicians should probably be directed to the respective physics/math categories")]
    MathematicalPhysics,
    [Description("math.NA - (Numerical Analysis) - Numerical algorithms for problems in analysis and algebra, scientific computation")]
    NumericalAnalysis_math,
    [Description("math.NT - (Number Theory) - Prime numbers, diophantine equations, analytic number theory, algebraic number theory, arithmetic geometry, Galois theory")]
    NumberTheory,
    [Description("math.OA - (Operator Algebras) - Algebras of operators on Hilbert space, C^*-algebras, von Neumann algebras, non-commutative geometry")]
    OperatorAlgebras,
    [Description("math.OC - (Optimization and Control) - Operations research, linear programming, control theory, systems theory, optimal control, game theory")]
    OptimizationAndControl,
    [Description("math.PR - (Probability) - Theory and applications of probability and stochastic processes: e.g. central limit theorems, large deviations, stochastic differential equations, models from statistical mechanics, queuing theory")]
    Probability,
    [Description("math.QA - (Quantum Algebra) - Quantum groups, skein theories, operadic and diagrammatic algebra, quantum field theory")]
    QuantumAlgebra,
    [Description("math.RA - (Rings and Algebras) - Non-commutative rings and algebras, non-associative algebras, universal algebra and lattice theory, linear algebra, semigroups")]
    RingsAndAlgebras,
    [Description("math.RT - (Representation Theory) - Linear representations of algebras and groups, Lie theory, associative algebras, multilinear algebra")]
    RepresentationTheory,
    [Description("math.SG - (Symplectic Geometry) - Hamiltonian systems, symplectic flows, classical integrable systems")]
    SymplecticGeometry,
    [Description("math.SP - (Spectral Theory) - Schrodinger operators, operators on manifolds, general differential operators, numerical studies, integral operators, discrete models, resonances, non-self-adjoint operators, random operators/matrices")]
    SpectralTheory,
    [Description("math.ST - (Statistics Theory) - Applied, computational and theoretical statistics: e.g. statistical inference, regression, time series, multivariate analysis, data analysis, Markov chain Monte Carlo, design of experiments, case studies")]
    StatisticsTheory,
    [Description("astro-ph.CO - (Cosmology and Nongalactic Astrophysics) - Phenomenology of early universe, cosmic microwave background, cosmological parameters, primordial element abundances, extragalactic distance scale, large-scale structure of the universe. Groups, superclusters, voids, intergalactic medium. Particle astrophysics: dark energy, dark matter, baryogenesis, leptogenesis, inflationary models, reheating, monopoles, WIMPs, cosmic strings, primordial black holes, cosmological gravitational radiation")]
    CosmologyAndNongalacticAstrophysics,
    [Description("astro-ph.EP - (Earth and Planetary Astrophysics) - Interplanetary medium, planetary physics, planetary astrobiology, extrasolar planets, comets, asteroids, meteorites. Structure and formation of the solar system")]
    EarthAndPlanetaryAstrophysics,
    [Description("astro-ph.GA - (Astrophysics of Galaxies) - Phenomena pertaining to galaxies or the Milky Way. Star clusters, HII regions and planetary nebulae, the interstellar medium, atomic and molecular clouds, dust. Stellar populations. Galactic structure, formation, dynamics. Galactic nuclei, bulges, disks, halo. Active Galactic Nuclei, supermassive black holes, quasars. Gravitational lens systems. The Milky Way and its contents")]
    AstrophysicsOfGalaxies,
    [Description("astro-ph.HE - (High Energy Astrophysical Phenomena) - Cosmic ray production, acceleration, propagation, detection. Gamma ray astronomy and bursts, X-rays, charged particles, supernovae and other explosive phenomena, stellar remnants and accretion systems, jets, microquasars, neutron stars, pulsars, black holes")]
    HighEnergyAstrophysicalPhenomena,
    [Description("astro-ph.IM - (Instrumentation and Methods for Astrophysics) - Detector and telescope design, experiment proposals. Laboratory Astrophysics. Methods for data analysis, statistical methods. Software, database design")]
    InstrumentationAndMethodsForAstrophysics,
    [Description("astro-ph.SR - (Solar and Stellar Astrophysics) - White dwarfs, brown dwarfs, cataclysmic variables. Star formation and protostellar systems, stellar astrobiology, binary and multiple systems of stars, stellar evolution and structure, coronas. Central stars of planetary nebulae. Helioseismology, solar neutrinos, production and detection of gravitational radiation from stellar systems")]
    SolarAndStellarAstrophysics,
    [Description("cond-mat.dis-nn - (Disordered Systems and Neural Networks) - Glasses and spin glasses; properties of random, aperiodic and quasiperiodic systems; transport in disordered media; localization; phenomena mediated by defects and disorder; neural networks")]
    DisorderedSystemsAndNeuralNetworks,
    [Description("cond-mat.mes-hall - (Mesoscale and Nanoscale Physics) - Semiconducting nanostructures: quantum dots, wires, and wells. Single electronics, spintronics, 2d electron gases, quantum Hall effect, nanotubes, graphene, plasmonic nanostructures")]
    MesoscaleAndNanoscalePhysics,
    [Description("cond-mat.mtrl-sci - (Materials Science) - Techniques, synthesis, characterization, structure.  Structural phase transitions, mechanical properties, phonons. Defects, adsorbates, interfaces")]
    MaterialsScience,
    [Description("cond-mat.other - (Other Condensed Matter) - Work in condensed matter that does not fit into the other cond-mat classifications")]
    OtherCondensedMatter,
    [Description("cond-mat.quant-gas - (Quantum Gases) - Ultracold atomic and molecular gases, Bose-Einstein condensation, Feshbach resonances, spinor condensates, optical lattices, quantum simulation with cold atoms and molecules, macroscopic interference phenomena")]
    QuantumGases,
    [Description("cond-mat.soft - (Soft Condensed Matter) - Membranes, polymers, liquid crystals, glasses, colloids, granular matter")]
    SoftCondensedMatter,
    [Description("cond-mat.stat-mech - (Statistical Mechanics) - Phase transitions, thermodynamics, field theory, non-equilibrium phenomena, renormalization group and scaling, integrable models, turbulence")]
    StatisticalMechanics,
    [Description("cond-mat.str-el - (Strongly Correlated Electrons) - Quantum magnetism, non-Fermi liquids, spin liquids, quantum criticality, charge density waves, metal-insulator transitions")]
    StronglyCorrelatedElectrons,
    [Description("cond-mat.supr-con - (Superconductivity) - Superconductivity: theory, models, experiment.  Superflow in helium")]
    Superconductivity,
    [Description("gr-qc - (General Relativity and Quantum Cosmology) - General Relativity and Quantum Cosmology Areas of gravitational physics, including experiments and observations related to the detection and interpretation of gravitational waves, experimental tests of gravitational theories, computational general relativity, relativistic astrophysics, solutions to Einstein's equations and their properties, alternative theories of gravity, classical and quantum cosmology, and quantum gravity.")]
    GeneralRelativityAndQuantumCosmology,
    [Description("hep-ex - (High Energy Physics - Experiment) - Description coming soon")]
    HighEnergyPhysicsExperiment,
    [Description("hep-lat - (High Energy Physics - Lattice) - Lattice field theory. Phenomenology from lattice field theory. Algorithms for lattice field theory.  Hardware for lattice field theory.")]
    HighEnergyPhysicsLattice,
    [Description("hep-ph - (High Energy Physics - Phenomenology) - Theoretical particle physics and its interrelation with experiment. Prediction of particle physics observables: models, effective field theories, calculation techniques. Particle physics: analysis of theory through experimental results.")]
    HighEnergyPhysicsPhenomenology,
    [Description("hep-th - (High Energy Physics - Theory) - Formal aspects of quantum field theory. String theory, supersymmetry and supergravity.")]
    HighEnergyPhysicsTheory,
    [Description("math-ph - (Mathematical Physics) - Articles in this category focus on areas of research that illustrate the application of mathematics to problems in physics, develop mathematical methods for such applications, or provide mathematically rigorous formulations of existing physical theories. Submissions to math-ph should be of interest to both physically oriented mathematicians and mathematically oriented physicists; submissions which are primarily of interest to theoretical physicists or to mathematicians should probably be directed to the respective physics/math categories")]
    MathematicalPhysics_math_ph,
    [Description("nlin.AO - (Adaptation and Self-Organizing Systems) - Adaptation, self-organizing systems, statistical physics, fluctuating systems, stochastic processes, interacting particle systems, machine learning")]
    AdaptationAndSystems,
    [Description("nlin.CD - (Chaotic Dynamics) - Dynamical systems, chaos, quantum chaos, topological dynamics, cycle expansions, turbulence, propagation")]
    ChaoticDynamics,
    [Description("nlin.CG - (Cellular Automata and Lattice Gases) - Computational methods, time series analysis, signal processing, wavelets, lattice gases")]
    CellularAutomataAndLatticeGases,
    [Description("nlin.PS - (Pattern Formation and Solitons) - Pattern formation, coherent structures, solitons")]
    PatternFormationAndSolitons,
    [Description("nlin.SI - (Exactly Solvable and Integrable Systems) - Exactly solvable systems, integrable PDEs, integrable ODEs, Painleve analysis, integrable discrete maps, solvable lattice models, integrable quantum systems")]
    ExactlySolvableAndIntegrableSystems,
    [Description("nucl-ex - (Nuclear Experiment) - Nuclear Experiment Results from experimental nuclear physics including the areas of fundamental interactions, measurements at low- and medium-energy, as well as relativistic heavy-ion collisions.  Does not include: detectors and instrumentation nor analysis methods to conduct experiments; descriptions of experimental programs (present or future); comments on published results")]
    NuclearExperiment,
    [Description("nucl-th - (Nuclear Theory) - Nuclear Theory Theory of nuclear structure covering wide area from models of hadron structure to neutron stars. Nuclear equation of states at different external conditions. Theory of nuclear reactions including heavy-ion reactions at low and high energies. It does not include problems of data analysis, physics of nuclear reactors, problems of safety, reactor construction")]
    NuclearTheory,
    [Description("physics.acc-ph - (Accelerator Physics) - Accelerator theory and simulation. Accelerator technology. Accelerator experiments. Beam Physics. Accelerator design and optimization. Advanced accelerator concepts. Radiation sources including synchrotron light sources and free electron lasers. Applications of accelerators.")]
    AcceleratorPhysics,
    [Description("physics.ao-ph - (Atmospheric and Oceanic Physics) - Atmospheric and oceanic physics and physical chemistry, biogeophysics, and climate science")]
    AtmosphericAndOceanicPhysics,
    [Description("physics.app-ph - (Applied Physics) - Applications of physics to new technology, including electronic devices, optics, photonics, microwaves, spintronics, advanced materials, metamaterials, nanotechnology, and energy sciences.")]
    AppliedPhysics,
    [Description("physics.atm-clus - (Atomic and Molecular Clusters) - Atomic and molecular clusters, nanoparticles: geometric, electronic, optical, chemical, magnetic properties, shell structure, phase transitions, optical spectroscopy, mass spectrometry, photoelectron spectroscopy, ionization potential, electron affinity, interaction with intense light pulses, electron diffraction, light scattering, ab initio calculations, DFT theory, fragmentation, Coulomb explosion, hydrodynamic expansion.")]
    AtomicAndMolecularClusters,
    [Description("physics.atom-ph - (Atomic Physics) - Atomic and molecular structure, spectra, collisions, and data. Atoms and molecules in external fields. Molecular dynamics and coherent and optical control. Cold atoms and molecules. Cold collisions. Optical lattices.")]
    AtomicPhysics,
    [Description("physics.bio-ph - (Biological Physics) - Molecular biophysics, cellular biophysics, neurological biophysics, membrane biophysics, single-molecule biophysics, ecological biophysics, quantum phenomena in biological systems (quantum biophysics), theoretical biophysics, molecular dynamics/modeling and simulation, game theory, biomechanics, bioinformatics, microorganisms, virology, evolution, biophysical methods.")]
    BiologicalPhysics,
    [Description("physics.chem-ph - (Chemical Physics) - Experimental, computational, and theoretical physics of atoms, molecules, and clusters - Classical and quantum description of states, processes, and dynamics; spectroscopy, electronic structure, conformations, reactions, interactions, and phases. Chemical thermodynamics. Disperse systems. High pressure chemistry. Solid state chemistry. Surface and interface chemistry.")]
    ChemicalPhysics,
    [Description("physics.class-ph - (Classical Physics) - Newtonian and relativistic dynamics; many particle systems; planetary motions; chaos in classical dynamics. Maxwell's  equations and  dynamics of charged systems and  electromagnetic forces in materials. Vibrating systems such as membranes and cantilevers; optomechanics. Classical waves, including acoustics and elasticity; physics of music and musical instruments. Classical thermodynamics and  heat flow problems.")]
    ClassicalPhysics,
    [Description("physics.comp-ph - (Computational Physics) - All aspects of computational science applied to physics.")]
    ComputationalPhysics,
    [Description("physics.data-an - (Data Analysis, Statistics and Probability) - Methods, software and hardware for physics data analysis: data processing and storage; measurement methodology; statistical and mathematical aspects such as parametrization and uncertainties.")]
    DataStatisticsAndProbability,
    [Description("physics.ed-ph - (Physics Education) - Report of results of a research study, laboratory experience, assessment or classroom practice that represents a way to improve teaching and learning in physics. Also, report on misconceptions of students, textbook errors, and other similar information relative to promoting physics understanding.")]
    PhysicsEducation,
    [Description("physics.flu-dyn - (Fluid Dynamics) - Turbulence, instabilities, incompressible/compressible flows, reacting flows. Aero/hydrodynamics, fluid-structure interactions, acoustics. Biological fluid dynamics, micro/nanofluidics, interfacial phenomena. Complex fluids, suspensions and granular flows, porous media flows. Geophysical flows, thermoconvective and stratified flows. Mathematical and computational methods for fluid dynamics, fluid flow models, experimental techniques.")]
    FluidDynamics,
    [Description("physics.gen-ph - (General Physics) - Description coming soon")]
    GeneralPhysics,
    [Description("physics.geo-ph - (Geophysics) - Atmospheric physics. Biogeosciences. Computational geophysics. Geographic location. Geoinformatics. Geophysical techniques. Hydrospheric geophysics. Magnetospheric physics. Mathematical geophysics. Planetology. Solar system. Solid earth geophysics. Space plasma physics. Mineral physics. High pressure physics.")]
    Geophysics,
    [Description("physics.hist-ph - (History and Philosophy of Physics) - History and philosophy of all branches of physics, astrophysics, and cosmology, including appreciations of physicists.")]
    HistoryAndPhilosophyOfPhysics,
    [Description("physics.ins-det - (Instrumentation and Detectors) - Instrumentation and Detectors for research in natural science, including optical, molecular, atomic, nuclear and particle physics instrumentation and the associated electronics, services, infrastructure and control equipment.")]
    InstrumentationAndDetectors,
    [Description("physics.med-ph - (Medical Physics) - Radiation therapy. Radiation dosimetry. Biomedical imaging modelling.  Reconstruction, processing, and analysis. Biomedical system modelling and analysis. Health physics. New imaging or therapy modalities.")]
    MedicalPhysics,
    [Description("physics.optics - (Optics) - Adaptive optics. Astronomical optics. Atmospheric optics. Biomedical optics. Cardinal points. Collimation. Doppler effect. Fiber optics. Fourier optics. Geometrical optics (Gradient index optics. Holography. Infrared optics. Integrated optics. Laser applications. Laser optical systems. Lasers. Light amplification. Light diffraction. Luminescence. Microoptics. Nano optics. Ocean optics. Optical computing. Optical devices. Optical imaging. Optical materials. Optical metrology. Optical microscopy. Optical properties. Optical signal processing. Optical testing techniques. Optical wave propagation. Paraxial optics. Photoabsorption. Photoexcitations. Physical optics. Physiological optics. Quantum optics. Segmented optics. Spectra. Statistical optics. Surface optics. Ultrafast optics. Wave optics. X-ray optics.")]
    Optics,
    [Description("physics.plasm-ph - (Plasma Physics) - Fundamental plasma physics. Magnetically Confined Plasmas (includes magnetic fusion energy research). High Energy Density Plasmas (inertial confinement plasmas, laser-plasma interactions). Ionospheric, Heliophysical, and Astrophysical plasmas (includes sun and solar system plasmas). Lasers, Accelerators, and Radiation Generation. Low temperature plasmas and plasma applications (include dusty plasmas, semiconductor etching, plasma-based nanotechnology, medical applications). Plasma Diagnostics, Engineering and Enabling Technologies (includes fusion reactor design, heating systems, diagnostics, experimental techniques)")]
    PlasmaPhysics,
    [Description("physics.pop-ph - (Popular Physics) - Description coming soon")]
    PopularPhysics,
    [Description("physics.soc-ph - (Physics and Society) - Structure, dynamics and collective behavior of societies and groups (human or otherwise). Quantitative analysis of social networks and other complex networks. Physics and engineering of infrastructure and systems of broad societal impact (e.g., energy grids, transportation networks).")]
    PhysicsAndSociety,
    [Description("physics.space-ph - (Space Physics) - Space plasma physics. Heliophysics. Space weather. Planetary magnetospheres, ionospheres and magnetotail. Auroras. Interplanetary space. Cosmic rays. Synchrotron radiation. Radio astronomy.")]
    SpacePhysics,
    [Description("quant-ph - (Quantum Physics) - Description coming soon")]
    QuantumPhysics,
    [Description("q-bio.BM - (Biomolecules) - DNA, RNA, proteins, lipids, etc.; molecular structures and folding kinetics; molecular interactions; single-molecule manipulation.")]
    Biomolecules,
    [Description("q-bio.CB - (Cell Behavior) - Cell-cell signaling and interaction; morphogenesis and development; apoptosis; bacterial conjugation; viral-host interaction; immunology")]
    CellBehavior,
    [Description("q-bio.GN - (Genomics) - DNA sequencing and assembly; gene and motif finding; RNA editing and alternative splicing; genomic structure and processes (replication, transcription, methylation, etc); mutational processes.")]
    Genomics,
    [Description("q-bio.MN - (Molecular Networks) - Gene regulation, signal transduction, proteomics, metabolomics, gene and enzymatic networks")]
    MolecularNetworks,
    [Description("q-bio.NC - (Neurons and Cognition) - Synapse, cortex, neuronal dynamics, neural network, sensorimotor control, behavior, attention")]
    NeuronsAndCognition,
    [Description("q-bio.OT - (Other Quantitative Biology) - Work in quantitative biology that does not fit into the other q-bio classifications")]
    OtherQuantitativeBiology,
    [Description("q-bio.PE - (Populations and Evolution) - Population dynamics, spatio-temporal and epidemiological models, dynamic speciation, co-evolution, biodiversity, foodwebs, aging; molecular evolution and phylogeny; directed evolution; origin of life")]
    PopulationsAndEvolution,
    [Description("q-bio.QM - (Quantitative Methods) - All experimental, numerical, statistical and mathematical contributions of value to biology")]
    QuantitativeMethods,
    [Description("q-bio.SC - (Subcellular Processes) - Assembly and control of subcellular structures (channels, organelles, cytoskeletons, capsules, etc.); molecular motors, transport, subcellular localization; mitosis and meiosis")]
    SubcellularProcesses,
    [Description("q-bio.TO - (Tissues and Organs) - Blood flow in vessels, biomechanics of bones, electrical waves, endocrine system, tumor growth")]
    TissuesAndOrgans,
    [Description("q-fin.CP - (Computational Finance) - Computational methods, including Monte Carlo, PDE, lattice and other numerical methods with applications to financial modeling")]
    ComputationalFinance,
    [Description("q-fin.EC - (Economics) - q-fin.EC is an alias for econ.GN. Economics, including micro and macro economics, international economics, theory of the firm, labor economics, and other economic topics outside finance")]
    Economics,
    [Description("q-fin.GN - (General Finance) - Development of general quantitative methodologies with applications in finance")]
    GeneralFinance,
    [Description("q-fin.MF - (Mathematical Finance) - Mathematical and analytical methods of finance, including stochastic, probabilistic and functional analysis, algebraic, geometric and other methods")]
    MathematicalFinance,
    [Description("q-fin.PM - (Portfolio Management) - Security selection and optimization, capital allocation, investment strategies and performance measurement")]
    PortfolioManagement,
    [Description("q-fin.PR - (Pricing of Securities) - Valuation and hedging of financial securities, their derivatives, and structured products")]
    PricingOfSecurities,
    [Description("q-fin.RM - (Risk Management) - Measurement and management of financial risks in trading, banking, insurance, corporate and other applications")]
    RiskManagement,
    [Description("q-fin.ST - (Statistical Finance) - Statistical, econometric and econophysics analyses with applications to financial markets and economic data")]
    StatisticalFinance,
    [Description("q-fin.TR - (Trading and Market Microstructure) - Market microstructure, liquidity, exchange and auction design, automated trading, agent-based modeling and market-making")]
    TradingAndMarketMicrostructure,
    [Description("stat.AP - (Applications) - Biology, Education, Epidemiology, Engineering, Environmental Sciences, Medical, Physical Sciences, Quality Control, Social Sciences")]
    Applications,
    [Description("stat.CO - (Computation) - Algorithms, Simulation, Visualization")]
    Computation,
    [Description("stat.ME - (Methodology) - Design, Surveys, Model Selection, Multiple Testing, Multivariate Methods, Signal and Image Processing, Time Series, Smoothing, Spatial Statistics, Survival Analysis, Nonparametric and Semiparametric Methods")]
    Methodology,
    [Description("stat.ML - (Machine Learning) - Covers machine learning papers (supervised, unsupervised, semi-supervised learning, graphical models, reinforcement learning, bandits, high dimensional inference, etc.) with a statistical or theoretical grounding")]
    MachineLearning_stat,
    [Description("stat.OT - (Other Statistics) - Work in statistics that does not fit into the other stat classifications")]
    OtherStatistics,
    [Description("stat.TH - (Statistics Theory) - stat.TH is an alias for math.ST. Asymptotics, Bayesian Inference, Decision Theory, Estimation, Foundations, Inference, Testing.")]
    StatisticsTheory_stat,
}

internal static class ArxivUtils
{
    internal static string GetCategoryDescription(ArxivCategory category)
    {
        var type = category.GetType();
        var memInfo = type.GetMember(category.ToString());
        var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
        return ((DescriptionAttribute)attributes[0]).Description.Split('-')[0].Trim();
    }
}
